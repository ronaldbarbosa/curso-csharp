using Exercicio_proposto.Entities;

namespace Exercicio_proposto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<Product> productsList = new List<Product>(); 

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productsType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productsName = Console.ReadLine();
                Console.Write("Price: ");
                double productsPrice = double.Parse(Console.ReadLine());

                switch (productsType)
                {
                    case 'c':
                        productsList.Add(new Product(productsName, productsPrice));
                        break;
                    case 'u':
                        Console.Write("Manufature date (MM/DD/YYYY): ");
                        DateTime productsManufatureDate = DateTime.Parse(Console.ReadLine());
                        productsList.Add(new UsedProduct(productsName, productsPrice, productsManufatureDate));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double productsCustomsFee = double.Parse(Console.ReadLine());
                        productsList.Add(new ImportedProduct(productsName, productsPrice, productsCustomsFee));
                        break;
                    default:
                        Console.WriteLine("Invalid type!");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}