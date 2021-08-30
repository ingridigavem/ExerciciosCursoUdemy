using ResolucaoExercicio1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ResolucaoExercicio1.Entities {
    class Order {

        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus orderStatus, Client client) {
            Moment = DateTime.Now;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            stringBuilder.AppendLine($"Order status: {OrderStatus.ToString()} ");
            stringBuilder.AppendLine(Client.ToString());
            stringBuilder.AppendLine("Order items:");

            foreach (OrderItem item in Items) {
                stringBuilder.AppendLine(item.ToString());
            }

            stringBuilder.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)} ");

            return stringBuilder.ToString();
        }
    }
}
