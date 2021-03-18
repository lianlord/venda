namespace Venda.model {
    public class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double valor) {
            Name = name;
            Price = valor;
        }
    }
}