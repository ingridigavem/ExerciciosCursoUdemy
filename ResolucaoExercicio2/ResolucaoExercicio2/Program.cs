using ResolucaoExercicio2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ResolucaoExercicio2 {
    class Program {
        static void Main(string[] args) {

            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int quantityProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityProducts; i++) {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string typeProduct = Console.ReadLine();

                switch (typeProduct) {
                    case "c":
                        products.Add(CommonProductBuilder());
                        break;
                    case "u":
                        products.Add(UsedProductBuilder());
                        break;
                    case "i":
                        products.Add(ImportedProductBuilder());
                        break;
                    default:
                        throw new Exception("This type doesn't exist");
                }
            }
            Console.WriteLine();
            foreach (Product product in products) {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(product.PriceTag());
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();
            }
        }

        static Product CommonProductBuilder() {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Product(name, price);
        }
        static UsedProduct UsedProductBuilder() {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Manufacture date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            return new UsedProduct(name, price, date);
        }
        static ImportedProduct ImportedProductBuilder() {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Customs fee: ");
            double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new ImportedProduct(name, price, fee);
        }
    }
}
