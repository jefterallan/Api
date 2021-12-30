namespace ApiSample.Data.Models
{
    public class Orders : Model
    {
        public int Number { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public Clients Client { get; set; }
        public ICollection<Products> Product { get; set; }

        public Orders()
        {
            Number = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Client = new Clients();
            Product = new List<Products>();

        }

        public Orders(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Clients client, Products product)
        {
            Number = number;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Client = client;
            Product = new List<Products>() { product };
        }

        public Orders(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, Clients client, ICollection<Products> product)
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
