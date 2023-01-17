using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Order order1 = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order1);

            string txt = OrderStatus.Processing.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os.GetType());
        }
    }
}