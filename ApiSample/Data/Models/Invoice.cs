namespace ApiSample.Data.Models
{
    public class Invoice : Model
    {
        public int Number { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public Provider Provider { get; set; }
        public ICollection<Product> Product { get; set; }

        public Invoice()
        {
            Number = 0;
            Tax = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Provider = new Provider();
            Product = new List<Product>();
        }

        public Invoice(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Provider provider, Product product)
        {
            Number = number;
            Tax = tax;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Provider = provider;
            Product = new List<Product>() { product };
        }

        public Invoice(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Provider provider, ICollection<Product> product)
        {
            Number = number;
            Tax = tax;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Provider = provider;
            Product = product;
        }
    }
}
