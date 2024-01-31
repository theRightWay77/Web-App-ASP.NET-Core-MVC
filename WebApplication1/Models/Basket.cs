using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Basket
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public static readonly List<BasketItem> basketItems = new List<BasketItem>();

        public decimal TotalCost 
        { 
            get
            { return basketItems.Sum(x => x.Cost); }           
        }


        public List<Product> GetBasket() { return basketItems; }

        public bool IsEmpty()
        {
            if (basketItems.Count == 0) return true;
            return false;
        }

        public void Add(Product prod)
        {
            basketItems.Add(prod);
        }

        public int GetProductsCount()
        {
            return basketItems.Count;
        }
    }
}
