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


            var myProduct = (object)productRepository.TryGetById(id) ?? "Товара с такии id не существует";
            return View(myProduct);

        }

        public IActionResult ShowBasket(int id, bool isNull)
        {         

            if (isNull)
            {
                if(!IsBasketEmpty())
                return View(productRepository.GetBasket());
                else return View("EmptyBasket");
            }

            productRepository.AddToBasket(productRepository.TryGetById(id));

            return View(productRepository.GetBasket());
        }
        private bool IsBasketEmpty()
        {
            if (productRepository.GetBasket().Count() == 0)
            {
                return true;
            }
            return false;
        }

    }
}
