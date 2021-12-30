namespace ApiSample.Data.Models
{
    public class Prices : Model
    {
        public decimal Cost { get; set; }
        public decimal Sell { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public ICollection<ProductPrices> ProductPrice { get; set;}

        public Prices()
        {
            Cost = 0;
            Sell = 0;
            InitialDate = DateTime.Today;
            FinalDate = DateTime.Today.AddDays(1);
            ProductPrice = new List<ProductPrices>();
        }

        public Prices(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ProductPrices? productPrice = null)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice != null ? new List<ProductPrices>() { productPrice } : new List<ProductPrices>();
        }

        public Prices(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ICollection<ProductPrices> productPrice)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice;
        }
    }
}
