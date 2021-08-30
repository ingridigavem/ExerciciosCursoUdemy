using System.Globalization;

namespace ResolucaoExercicio1.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product) {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal() {
            return Product.Price * Quantity;
        }

        public override string ToString() {
            return $"{Product}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
