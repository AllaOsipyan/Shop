using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class FirstPageController : Controller
    {
        
        public IActionResult MPage()
        {
            return RedirectToAction("Login","Account" );
        }

    }
}