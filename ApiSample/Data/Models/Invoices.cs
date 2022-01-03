namespace ApiSample.Data.Models
{
    public class Invoices : Model
    {
        public int Number { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public virtual Providers Provider { get; set; }
        public virtual ICollection<Products> Product { get; set; }

        public Invoices()
        {
            Number = 0;
            Tax = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Provider = new Providers();
            Product = new List<Products>();
        }

        public Invoices(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Providers provider, Products product)
        {
            Number = number;
            Tax = tax;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Provider = provider;
            Product = new List<Products>() { product };
        }

        public Invoices(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Providers provider, ICollection<Products> product)
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
