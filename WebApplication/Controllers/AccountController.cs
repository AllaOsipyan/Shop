using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLog;
using Shop_DB;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class AccountController: Controller
    {
        

        private string getLogInfo(HttpContext httpContext)
        {
            return "ip-" + httpContext.Connection.RemoteIpAddress.MapToIPv4().ToString() + "| user-agent: " + Request.Headers["User-Agent"].ToString() + " | user name:";
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            Client currUser = null;
            string existingPassword = null;

            
            if (!ModelState.IsValid)
            {
                logger.Info(getLogInfo(HttpContext) + model.userName + ": Не все поля были заполнены");
            }
            else
            {
                currUser = Client.getUserByLogin(model.userName);
                existingPassword = currUser != null ? currUser.password : null;

                HomeController.dbConn.m_dbConn.Open();
                if (HomeController.dbConn.UserIsNotCreated(model.userName))
                {
                    ViewBag.Error = "Пользователь не найден.";
                    logger.Info(getLogInfo(HttpContext) + model.userName+": Пользователь не найден");
                }
                else if (string.Compare(existingPassword, model.password, false, CultureInfo.InvariantCulture) != 0)
                {
                    ViewBag.Error = "Неправильный пароль";
                    logger.Info("Неправильный пароль");
                }
                else
                {
                    var userIdentity = new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.userName)
                    }, "login", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(userIdentity));
                    logger.Info(getLogInfo(HttpContext) + "Вход успешно выполнен");
                    return RedirectToAction("Index", "Home");

                }
                HomeController.dbConn.m_dbConn.Close();
            }

            return View();
            
        }
        
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegisterModel model)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(model, new ValidationContext(model), results, true))
            { 
                foreach (var err in results)
                logger.Info(getLogInfo(HttpContext) + model.userName + " " + err);

            }
                
            else
            {
                HomeController.dbConn.m_dbConn.Open();
                if (!HomeController.dbConn.UserIsNotCreated(model.userName))
                {
                    ViewBag.Error = "Пользователь с этим именем уже существует.";
                    logger.Info(getLogInfo(HttpContext) + model.userName + ": Пользователь с этим именем уже существует.");
                }
                else
                {
                    HomeController.dbConn.CreateUser(model.userName, model.password, model.email);
                    
                    Client.users.Add(new Client(model.userName, model.password, model.email));
                    var userIdentity = new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.userName)
                    }, "login", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(userIdentity));
                    logger.Info(getLogInfo(HttpContext) + model.userName + ": Вход успешно выполнен");
                    return RedirectToAction("Index", "Home");

                }
                HomeController.dbConn.m_dbConn.Close();
            }

            return View();
            
        }
       
        
        
    }
    
    
}