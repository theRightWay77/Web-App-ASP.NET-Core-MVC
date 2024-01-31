using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BasketController : Controller
    {
        private readonly ProductRepository productRepository;
        private readonly Basket basket;

        public BasketController()
        {
            basket = new Basket();
            productRepository = new ProductRepository();
        }

        public ActionResult Index()
        {
            Basket basket = BasketsRepository.TryGetByUserId(Constants.UserId);
            return View();
        }

        public IActionResult ShowBasket(int id, bool isNull)
        {

            if (isNull)
            {
                if (!basket.IsEmpty())
                    return View(basket);
                else return View("EmptyBasket");
            }

            basket.Add(productRepository.TryGetById(id));

            return View(basket);
        }
    }
}
