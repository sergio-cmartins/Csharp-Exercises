using System;
using System.Globalization;
using OrderManagement.Entities;
using OrderManagement.Entities.Enums;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client data 
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, clientEmail, clientBirth);

            //Base Order Data
            Console.WriteLine("Enter Order Data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            //Order Items
            Console.Write("How many items to this order? ");
            int nroItems = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nroItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, product);
                order.AddItem(orderItem);
            }

            //Print Results
            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
