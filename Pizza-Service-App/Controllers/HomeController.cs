using Microsoft.AspNetCore.Mvc;

namespace Pizza_Service_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
