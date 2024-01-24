using Microsoft.Extensions.Hosting;

namespace WebApplication1.Models
{
    public class Product
    {
        private static int IdCreator = 0;
        public int Id; // идентификатор товара.Нужно для уникальности объектов.
        public string Name; // название товара. 
        public int Сost; // стоимость товара.
        public string Description;// подробное описание товара

        public Product(string name, int сost, string description)
        {
            Id = IdCreator++;
            Name = name;
            Сost = сost;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\n{this.Name}\n{this.Сost} p.\n{this.Description}";
        }
    }
}
