using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController: Controller

    {
        public IActionResult MainPage()
        {
            return View();
        }
        [Authorize]
        public IActionResult Index()
        {
            
            return Content(User.Identity.Name);
        }
    }
}