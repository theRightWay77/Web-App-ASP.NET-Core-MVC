using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductsRepository productRepository;
        private readonly IBasketsRepository basketsRepository;
        private readonly Constants constants;
        private readonly Basket basket;

        public BasketController(IProductsRepository productRepository, IBasketsRepository basketsRepository, Constants constants)
        {
            //basket = new Basket();
            this.productRepository = productRepository;
            this.basketsRepository = basketsRepository;
            this.constants = constants;
        }

        public IActionResult Index() //показывает корзину текущего пользователя, если в ней что-то есть, если нет, пишет, что корзина пустая 
        {
            Basket basket = basketsRepository.TryGetByUserId(constants.UserId);
            return View(basket);
        }

        public IActionResult Add(int productId)
        {
            // var myProduct = (object)productRepository.TryGetById(productId) ?? "Товара с такии id не существует";
            var myProduct = productRepository.TryGetById(productId);
            basketsRepository.Add(myProduct, "UserId");
            return RedirectToAction("Index");
        }
    }
}
