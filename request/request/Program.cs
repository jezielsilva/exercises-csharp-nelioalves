using request.Order;
using System;
using System.Globalization;

namespace request.Order
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);
           

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                Console.Write($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantify: ");
                int quantify = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);
                OrderItem orderItem = new OrderItem(quantify, price, product);
                order.addItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
