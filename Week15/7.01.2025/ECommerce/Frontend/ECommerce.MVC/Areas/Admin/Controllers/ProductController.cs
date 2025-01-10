using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
