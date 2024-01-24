﻿using WebApplication1.Models;

namespace WebApplication1
{
    public class ProductRepository
    {
        static List<Product> Products = new List<Product>() {
            new Product("prod1", 10, "discr1"),
            new Product("prod2", 100, "discr2"),
            new Product("prod3", 1000, "discr3"),
            new Product("prod4", 10000, "discr4"),
            new Product("prod5", 100000, "discr5")
        };

        public ProductRepository()
        {

        }

        public List<Product> GetProducts() { return Products; }      

        internal object TryGetById(int id)
        {
            return Products.FirstOrDefault(product => product.Id == id);
         
        }
    }
}
