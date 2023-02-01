using Exercicio_proposto.Models;
using Exercicio_proposto.Models.Enums;

namespace Exercicio_proposto
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Clear();

            System.Console.WriteLine("Enter client data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (MM/DD/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            
            System.Console.WriteLine();

            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            System.Console.Write("How many items to this order? ");
            int numberOfItems = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            
            Order order = new Order(client, status);

            for (int i = 1; i <= numberOfItems; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string itemName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double itemPrice = double.Parse(Console.ReadLine());
                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(itemName, itemPrice);
                OrderItem item = new OrderItem(product, quantity, itemPrice);

                order.AddItem(item);
                System.Console.WriteLine();
            }

            System.Console.WriteLine();

            System.Console.WriteLine("ORDER SUMMARY:");
            System.Console.WriteLine(order.ToString());            
        }
    }
}