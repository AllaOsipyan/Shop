using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class AccountController: Controller
    {
       /* public static Dictionary<string, string> users = new Dictionary<string, string>()
        {
            ["Anna"]= "1234",
            ["Bob"] = "5678"
        };*/

        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
           
            Client currUser = null;
            string existingPassword = null;
            
           
            if (!ModelState.IsValid)
                ViewBag.Error = "Поле обязательно для заполнения.";
            else
            {
                currUser = Client.getUserByLogin(model.userName);
                existingPassword = currUser != null ? currUser.password : null;


                if (currUser == null)
                    ViewBag.Error = "Пользователь не найден.";
                else if (string.Compare(existingPassword, model.password, false, CultureInfo.InvariantCulture) != 0)
                    ViewBag.Error = "Неправильный пароль";
                else
                {
                    var userIdentity = new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.userName)
                    }, "login", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(userIdentity));

                    return RedirectToAction("Index", "Home");

                }
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
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model);
            if (!Validator.TryValidateObject(model, context, results, true))
                ViewBag.Error = results.Select(x=>x.ErrorMessage).First();
            else
            {
                Client currUser = Client.getUserByLogin(model.userName);
                if (currUser != null)
                    ViewBag.Error = "Пользователь с этим именем уже существует.";
                else
                {
                    Client.users.Add(new Client(model.userName, model.password, model.email));
                    var userIdentity = new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.userName)
                    }, "login", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(userIdentity));

                    return RedirectToAction("Index", "Home");

                }
            }

            return View();
            
        }
       
        
        
    }
    
    
}