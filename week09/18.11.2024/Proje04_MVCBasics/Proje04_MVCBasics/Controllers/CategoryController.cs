using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVCBasics.Controllers
{
    public class CategoryController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
