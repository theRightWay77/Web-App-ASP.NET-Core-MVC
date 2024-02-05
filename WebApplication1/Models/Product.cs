using Microsoft.Extensions.Hosting;

namespace WebApplication1.Models
{
    public class Product //описание самого продукта из ProductsRepository
    {
        private static int IdCreator = 0; //это че
        public int Id; // идентификатор товара.Нужно для уникальности объектов.
        public string Name; // название товара. 
        public int Cost; // стоимость товара.
        public string Description;// подробное описание товара
        public string ImagePath;

        public Product(string name, int сost, string description, string imagePath)
        {
            Id = IdCreator++;
            Name = name;
            Cost = сost;
            Description = description;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\n{this.Name}\n{this.Cost} p.\n{this.Description}";
        }

    }
}
