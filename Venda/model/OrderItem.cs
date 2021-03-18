namespace Venda.model {
    public class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem(int quantity, Product product) {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal() {
            return Price * Quantity;
        }
    }
}