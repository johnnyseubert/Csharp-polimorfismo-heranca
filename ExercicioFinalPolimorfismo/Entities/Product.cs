using System.Globalization;

namespace ExercicioFinalPolimorfismo.Entities
{
    public class Product
    {
        //properties
        public string Name { get; set; }
        public double Price { get; set; }
        //constructor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //methods
        public virtual string PriceTag()
        {
            return $"{Name} R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}