using Microsoft.Extensions.Hosting;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id; // идентификатор товара.Нужно для уникальности объектов.
        public string Name; // название товара. 
        public int Сost; // стоимость товара.
        public string Description;// подробное описание товара

        public Product(int id, string name, int сost)
        {
            Id = id;
            Name = name;
            Сost = сost;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\n{this.Name}\n{this.Сost} p.";
        }
    }
}
