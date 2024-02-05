using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Basket// корзина товаров, содержит список элементов класса BasketItem
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        //public static List<BasketItem> BasketItems = new List<BasketItem>();
        public List<BasketItem> BasketItems { get; set; }

        public decimal TotalCost 
        { 
            get
            { return BasketItems.Sum(x => x.Cost); }           
        }


      //  public List<BasketItem> GetBasket() { return BasketItems; }

        //public bool IsEmpty()
        //{
        //    if (BasketItems.Count == 0) return true;
        //    return false;
        //}

        //public void Add(BasketItem prod)
        //{
        //    BasketItems.Add(prod);
        //}

        public int GetProductsCount()
        {
            return BasketItems.Count;
        }
    }
}
