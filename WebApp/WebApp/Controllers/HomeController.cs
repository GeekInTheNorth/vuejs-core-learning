using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadFromApi()
        {
            return View();
        }

        public IActionResult LoadModelFromApi()
        {
            return View();
        }

        public IActionResult Collections()
        {
            return View();
        }
    }
}