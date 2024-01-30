using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
