using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly IProductsRepository productRepository;

        public ProductController(IProductsRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(int id) // показывает страницу с конкретным товаром
        {
           // var myProduct = (object)productRepository.TryGetById(id) ?? "Товара с такии id не существует";
            var myProduct = productRepository.TryGetById(id);
            return View(myProduct);
        }

    }
}
