namespace WebApplication1.Models
{
    public class BasketItem //карточка товара из корзины, содержит количество одинаковых товаров
    {
        public Guid Id { get; set; }
        public Product Product { get; set; } // продукт из ProductsRepository 
        public int Amount { get; set; } // количество такого рподукта в корзине

        public decimal Cost //цена за все такие продукты
        {
            get
            {
                return Product.Cost * Amount;
            }
        }
    }
}
