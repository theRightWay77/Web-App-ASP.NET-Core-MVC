using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Basket
    {
       public static readonly List<Product> products = new List<Product>();

        private int TotalCost { get; set; }

        public int GetTotalCost() 
        { 
            foreach (Product prod in products)
            {
                TotalCost += prod.Cost;
            }
            return TotalCost; 
        }
        public List<Product> GetBasket() { return products;}

        public bool IsEmpty()
        {
            if (products.Count == 0) return true;
            return false;
        }

        public void Add(Product prod)
        {
            products.Add(prod);
        }

        public int GetProductsCount()
        {
            return products.Count;
        }
    }
}
