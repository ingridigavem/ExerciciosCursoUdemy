using ResolucaoExercicio1.Entities;
using ResolucaoExercicio1.Entities.Enums;
using System;
using System.Globalization;

namespace ResolucaoExercicio1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter client data:");
            Client client = ClientBuilder();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(orderStatus, client);
            Order orderSumary = OrderBuilder(order);
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(orderSumary);

        }

        public static Client ClientBuilder() {

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            return new Client(name, email, birthDate);
        }

        public static Order OrderBuilder(Order order) {
            Console.Write("How many items to this order? ");
            int itemsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemsQuantity; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, new Product(productName, productPrice));

                order.AddItem(orderItem);

            }
            return order;
        }
    }
}
