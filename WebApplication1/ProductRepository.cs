using WebApplication1.Models;

namespace WebApplication1
{
    public class ProductRepository // список всех голых товаров
    {
        static List<Product> Products = new List<Product>() {
            new Product("prod1", 10, "discr1", "/images/img0.jpg"),
            new Product("prod2", 100, "discr2", "/images/img1.jpg"),
            new Product("prod3", 1000, "discr3", "/images/img2.jpg"),
            new Product("prod4", 10000, "discr4", "/images/img3.jpg"),
            new Product("prod5", 100000, "discr5", "/images/img4.jpg")
        };

        public ProductRepository()
        {

        }

        public List<Product> GetProducts() { return Products; }      

        internal Product TryGetById(int id)
        {
            return Products.FirstOrDefault(product => product.Id == id);
         
        }
    }
}
