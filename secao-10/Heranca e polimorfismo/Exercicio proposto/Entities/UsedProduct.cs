using System.Globalization;

namespace Exercicio_proposto.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }
        
        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufature date: {ManufatureDate.ToString("MM/dd/yyyy")})";
        }
    }
}