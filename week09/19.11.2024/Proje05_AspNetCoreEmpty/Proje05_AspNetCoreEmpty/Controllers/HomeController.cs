﻿using Microsoft.AspNetCore.Mvc;

namespace Proje05_AspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
