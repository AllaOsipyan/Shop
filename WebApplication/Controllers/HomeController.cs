using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop_DB;

namespace WebApplication.Controllers
{
    public class HomeController: Controller

    {
     /*   public IActionResult MainPage()
        {
            return View();
        } 
        */
        public static DB dbConn = new DB();
        public IActionResult Index()
        {
           
                dbConn.StartDB();
            
            if(HttpContext.User.Identity.IsAuthenticated)
                return View("MainPage");
            else
            {
                return View("~/Views/Account/Login.cshtml");
            }
        }
    }
}