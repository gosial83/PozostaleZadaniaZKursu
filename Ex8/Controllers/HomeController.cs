using Microsoft.AspNetCore.Mvc;

namespace Ex8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
