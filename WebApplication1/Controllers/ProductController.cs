using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;
       // private readonly Basket basket;
        public ProductController()
        {
            productRepository = new ProductRepository();
            //basket = new Basket();
        }

        public IActionResult Index(int id)
        {


            var myProduct = (object)productRepository.TryGetById(id) ?? "Товара с такии id не существует";
            return View(myProduct);

        }

        //public IActionResult ShowBasket(int id, bool isNull)
        //{         

        //    if (isNull)
        //    {
        //        if(!basket.IsEmpty())
        //        return View(basket);
        //        else return View("EmptyBasket");
        //    }

        //    basket.Add(productRepository.TryGetById(id));

        //    return View(basket);
        //}
        

    }
}
