using System;
using System.Globalization;

namespace ExercicioFinalPolimorfismo.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufacureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacureDate) : base(name, price)
        {
            ManufacureDate = manufacureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) R$ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufacureDate.ToString("dd/MM/yyyy")})";
        }
        
    }
}