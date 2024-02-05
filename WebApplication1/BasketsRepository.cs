using WebApplication1.Models;

namespace WebApplication1
{
    public static class BasketsRepository //список всех корзин всех пользователей, тут создается новая корзина, если у пользователя ее не было
    {
        private static List<Basket> baskets = new List<Basket>();

        
        internal static Basket TryGetByUserId(string userId) // находит и возвращает корзину текущего пользователя
        {
            return baskets.FirstOrDefault(x => x.UserId == userId);
        }

        internal static void Add(Product myProduct, string myUserId) //добавляет новую корзину, если в списке корзин нет подходящей к данному пользователю
        {
            var existingBasket = TryGetByUserId(myUserId);
            if (existingBasket == null)
            {
                var newBasket = new Basket // создает новую
                {
                    Id = Guid.NewGuid(),
                    UserId = myUserId,
                    BasketItems = new List<BasketItem>() //в список новой корзины сразу записывает товар, который пытался добавить пользователь
                    {
                        new BasketItem() {
                        Id = Guid.NewGuid(),
                        Product = myProduct,
                        Amount=1
                        }
                    }

                };
                baskets.Add(newBasket); 
            }
            else
            {
                var existingBasketItem = existingBasket.BasketItems.FirstOrDefault(x => x.Product.Id == myProduct.Id); //если корзина уже была, проверяет, а есть ли в ней такой товар или нет
                if (existingBasketItem != null) //если был, добавляет еще один к количеству этого товара
                {
                    existingBasketItem.Amount += 1;
                }
                else // если такого товара еще не было, создаем карточку товара для корзины с новым id в количестве 1 шт
                {
                    existingBasket.BasketItems.Add(new BasketItem() 
                    {
                        Id = Guid.NewGuid(),
                        Amount = 1,
                        Product = myProduct,
                    });
                }
            }
        }

        
    }
}
