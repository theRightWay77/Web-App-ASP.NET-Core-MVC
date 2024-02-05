using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BasketController : Controller
    {
        private readonly ProductRepository productRepository;
        private readonly BasketsRepository basketsRepository;
        private readonly Basket basket;

        public BasketController(ProductRepository productRepository, BasketsRepository basketsRepository)
        {
            basket = new Basket();
            this.productRepository = productRepository;
            this.basketsRepository = basketsRepository;
        }

        public IActionResult Index() //показывает корзину текущего пользователя, если в ней что-то есть, если нет, пишет, что корзина пустая 
        {
            Basket basket = basketsRepository.TryGetByUserId(Constants.UserId);
            return View(basket);
        }

        //public IActionResult ShowBasket(int id)
        //{

        //    if (isNull)
        //    {
        //        if (!basket.IsEmpty())
        //            return View(basket);
        //        else return View("EmptyBasket");
        //    }

        //    //basket = (BasketsRepository.TryGetByUserId(Constants.UserId));
        //    basket.Add(BasketsRepository.TryGetByUserId(Constants.UserId));

        //    return View(basket);
        //}

        public IActionResult Add(int productId)
        {


            // var myProduct = (object)productRepository.TryGetById(productId) ?? "Товара с такии id не существует";
            var myProduct = productRepository.TryGetById(productId, Constants.UserId);
            basketsRepository.Add(myProduct, "UserId");
            //return View(myProduct);
            return RedirectToAction("Index");
        }
    }
}
