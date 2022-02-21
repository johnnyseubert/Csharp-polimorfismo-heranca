using System.Globalization;

namespace ExercicioFinalPolimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        
        public double CustomsFee { get; set; }
        //properties
        
        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            CustomsFee = customsfee;
        }//constructors
        public override string PriceTag()
        {
            return $"{Name} R$ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                   $"(Customs Fee: R$ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }//PriceTag
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }//TotalPrice
        
    }
}