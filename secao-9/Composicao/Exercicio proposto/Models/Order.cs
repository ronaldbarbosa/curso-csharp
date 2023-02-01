using System.Text;
using Exercicio_proposto.Models.Enums;

namespace Exercicio_proposto.Models
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }

        public Order(Client client, OrderStatus status)
        {
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double totalValue = 0;
            foreach (OrderItem item in Items)
            {
                totalValue += item.SubTotal();
            }
            return totalValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("MM/dd/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2"));

            return sb.ToString();
        }
    }
}