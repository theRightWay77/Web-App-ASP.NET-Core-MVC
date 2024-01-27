using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;
        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index(int id)
        {
            
            
            var myProduct = productRepository.TryGetById(id) ?? "Товара с такии id не существует";
            return View(myProduct);

        }

    }
}
