namespace Learn_CSharp_DotNet.ExamPaper
{
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;
        private string producer;

        public int ProductId { get { return productId; } set { this.productId = value; } }
        public string Name { get { return name; } set { this.name = value; } }
        public double Price { get { return price; } set { this.price = value; } }
        public string Producer { get { return producer; } set { this.producer = value; } }

        public Product(int productId, string name, double price, string producer)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public abstract double computeTax();
    }
}
