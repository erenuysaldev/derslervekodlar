using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVCBasics.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult BestSellers()
        {
            return View();
        }
    }
}
