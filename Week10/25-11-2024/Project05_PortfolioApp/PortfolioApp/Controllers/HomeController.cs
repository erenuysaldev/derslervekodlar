using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context) 
    {
        
    }


    public IActionResult Index()
    {
        var Categories = _context.Categories.ToList();
        return View();
    }
}
