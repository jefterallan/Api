namespace ApiSample.Data.Models
{
    public class Order : Model
    {
        public int Number { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public Client Client { get; set; }
        public ICollection<Product> Product { get; set; }

        public Order()
        {
            Number = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Client = new Client();
            Product = new List<Product>();

        }

        public Order(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Client client, Product product)
        {
            Number = number;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Client = client;
            Product = new List<Product>() { product };
        }

        public Order(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Client client, ICollection<Product> product)
        {
            Number = number;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Client = client;
            Product = product;
        }
    }
}
