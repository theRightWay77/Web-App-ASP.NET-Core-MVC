using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        static List<Product> products = new List<Product>() {
            new Product(1, "prod1", 10),
            new Product(2, "prod2", 100),
            new Product(3, "prod3", 1000),
            new Product(4, "prod4", 10000),
            new Product(5, "prod5", 100000)
        };
        Catalog catalog = new Catalog(products);

        public string Index()
        {




            return string.Join("\n\n", products);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}