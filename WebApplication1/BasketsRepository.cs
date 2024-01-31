using WebApplication1.Models;

namespace WebApplication1
{
    public static class BasketsRepository
    {
        private static List<Basket> baskets = new List<Basket>();

        internal static Basket TryGetByUserId(string userId)
        {
            return baskets.FirstOrDefault(x => x.UserId == userId);
        }
    }
}
