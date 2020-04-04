using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController: Controller

    {
     /*   public IActionResult MainPage()
        {
            return View();
        } 
        */
      
        public IActionResult Index()
        {
            if(HttpContext.User.Identity.IsAuthenticated)
                return View("MainPage");
            else
            {
                return View("~/Views/Account/Login.cshtml");
            }
        }
    }
}