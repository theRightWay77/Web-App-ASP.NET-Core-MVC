using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;
      
        public HomeController()
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index() //выводит сетку всех товаров на главной странице
        {
            List<Product> products = productRepository.GetProducts();
            //return string.Join("\n\n", products);
            return View(products);
        }

        
    }
}