using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project06_EFCore_DbFirst.Models;
using Project06_EFCore_DbFirst.Models.Contexts;

namespace Project06_EFCore_DbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindDbContext _context;

        public HomeController(NorthwindDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

    }
}


