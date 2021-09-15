using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using request.Order;
using System.Globalization;
namespace request.Order
{
    class Order
    {
        public DateTime moment = DateTime.Now;
        public OrderStatus status { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
        Client client = new Client();
        Product product = new Product();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public Double total()
        {
            double total = 0.0;
            OrderItem order = new OrderItem();
            foreach(OrderItem item in items)
            {
                total += item.subTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: "+ moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in items)
            {
                sb.Append(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
    
}
