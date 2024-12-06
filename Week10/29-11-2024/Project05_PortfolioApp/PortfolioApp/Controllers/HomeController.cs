using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;
using PortfolioApp.Models.Entities;

namespace PortfolioApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}





// LINQ (Language Integrated Query)
// Söz Dizimi(Syntax):
// 1) Query Syntax
// 2) Method Syntax

/* 1) QUERY SYNTAX
 * var result = from item in collection
 *              where item.Price>100
 *              orderby item.Name
 *              select item;
 *              
 * 2) METHOD SYNTAX
 * var result = collection
 *                  .Where(item=>item.Price>100)
 *                  .OrderBy(item=>item.Name)
 *                  .Select(item=>item);
 */


//var categories = new List<Category>()
//        {
//            new Category{Id=1,Name="Kategori1",Description="Açýklama1",IsDeleted=true},
//            new Category{Id=2,Name="Kategori2",Description="Açýklama2",IsDeleted=true},
//            new Category{Id=3,Name="Kategori3",Description="Açýklama3",IsDeleted=true},
//            new Category{Id=4,Name="Kategori4",Description="Açýklama4",IsDeleted=false},
//            new Category{Id=5,Name="Kategori5",Description="Açýklama5",IsDeleted=true},
//            new Category{Id=6,Name="Kategori6",Description="Açýklama6",IsDeleted=true},
//            new Category{Id=7,Name="Kategori7",Description="Açýklama7",IsDeleted=true},
//            new Category{Id=8,Name="Kategori8",Description="Açýklama8",IsDeleted=false},
//            new Category{Id=9,Name="Kategori9",Description="Açýklama9",IsDeleted=true},
//            new Category{Id=10,Name="Kategori10",Description="Açýklama10",IsDeleted=false},
//        };

////1) Query Syntax
////var undeletedCategories = from category in categories
////                          where category.IsDeleted==false
////                          select category;

//// 2) Method Syntax
//var undeletedCategories = categories
//                            .Where(c => c.IsDeleted == false)
//                            .ToList();