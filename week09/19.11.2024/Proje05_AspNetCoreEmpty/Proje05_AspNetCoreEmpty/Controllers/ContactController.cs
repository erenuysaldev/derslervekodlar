using Microsoft.AspNetCore.Mvc;

namespace Proje05_AspNetCoreEmpty.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
