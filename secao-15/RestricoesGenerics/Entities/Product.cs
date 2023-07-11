using System.Globalization;

namespace RestricoesGenerics.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (obj is not Product) throw new ArgumentException("Comparing error: argument is not a Product");

            Product p = (Product)obj;

            return Price.CompareTo(p.Price);
        }
    }
}
