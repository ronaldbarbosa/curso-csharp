using System;

namespace vetores
{
    class vetores
    {
        public static void Main(string[] args)
        {
            int productsQuantity = int.Parse(Console.ReadLine());
            Product[] products = new Product[productsQuantity];
            double averagePrice, sum = 0;

            for (int i = 0; i < productsQuantity; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                products[i] = new Product(name, price);
            }

            foreach (var product in products)
            {
                sum += product.Price;
            }
            averagePrice = sum / productsQuantity;

            Console.WriteLine($"Average price = $ {averagePrice.ToString("F2")}");
        }
    }
}