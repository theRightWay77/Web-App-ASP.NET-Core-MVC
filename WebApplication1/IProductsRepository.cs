using WebApplication1.Models;

namespace WebApplication1
{
    public interface IProductsRepository
    {
        static List<Product> Products { get; }


        public List<Product> GetProducts() { return Products; }

        public Product TryGetById(int id) { return Products.FirstOrDefault(product => product.Id == id); }


        //Product TryGetById(int id)
        //{
        //    return Products.FirstOrDefault(product => product.Id == id);

        //}
        //public List<Product> GetProducts() { return Products; }
    }
}
