using Microsoft.AspNetCore.Mvc;
using Proje05_AspNetCoreEmpty.Models;

namespace Proje05_AspNetCoreEmpty.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<Product> _products;
        public ProductController()
        {
            _products = [
                new(){Id=1,Name="Kitap1",Description="Güzel bir kitap",ImageUrl="kitap1.jpg"},   
                
                new(){Id=2,Name="Kitap2",Description="Harika bir kitap",ImageUrl="kitap2.jpg"},    

                new(){Id=3,Name="Kitap3",Description="Mük bir kitap",ImageUrl="kitap3.jpg"},    

                new(){Id=4,Name="Kitap4",Description="Berbat bir kitap",ImageUrl="kitap4.jpg"},    

                new(){Id=5,Name="Kitap5",Description="Bu da kitap mı?",ImageUrl="kitap5.jpg"},

                new(){Id=6,Name="Kitap6",Description="Güzel bir kitap",ImageUrl="kitap6.jpg"},

                new(){Id=7,Name="Kitap7",Description="Harika bir kitap",ImageUrl="kitap7.jpg"},

                new(){Id=8,Name="Kitap8",Description="Mük bir kitap",ImageUrl="kitap8.jpg"},

                new(){Id=9,Name="Kitap9",Description="Berbat bir kitap",ImageUrl="kitap9.jpg"},

                new(){Id=10,Name="Kitap10",Description="Bu da kitap mı?",ImageUrl="kitap10.jpg"},

                new(){Id=11,Name="Kitap11",Description="Berbat bir kitap",ImageUrl="kitap11.jpg"},

                new(){Id=12,Name="Kitap12",Description="Bu da kitap mı?",ImageUrl="kitap12.jpg"},
            ];
        }
        public IActionResult Index()
        {
            ViewBag.Products= _products;
            return View();
        }
        public IActionResult Details(int id)
        {
            Product product=null;
            foreach (Product p in _products)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            ViewBag.Product= product;
            return View();
        }
    }
}
