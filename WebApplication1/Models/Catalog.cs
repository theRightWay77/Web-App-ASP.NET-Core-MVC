namespace WebApplication1.Models
{
    public class Catalog
    {
        public List<Product> Products = new List<Product>();

        public Catalog(List<Product> products)
        {
            Products = products;
        }
    }
}
