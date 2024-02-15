using WebApplication1.Models;

namespace WebApplication1
{
    public interface IBasketsRepository
    {
        private static List<Basket> baskets { get; }

        public Basket TryGetByUserId(string userId) // находит и возвращает корзину текущего пользователя
        {
            return baskets.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product myProduct, string myUserId) { }

    }
}
