namespace ApiSample.Data.Models
{
    public class Price : Model
    {
        public decimal Cost { get; set; }
        public decimal Sell { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public ICollection<ProductPrice> ProductPrice { get; set;}

        public Price()
        {
            Cost = 0;
            Sell = 0;
            InitialDate = DateTime.Today;
            FinalDate = DateTime.Today.AddDays(1);
            ProductPrice = new List<ProductPrice>();
        }

        public Price(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ProductPrice? productPrice = null)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice != null ? new List<ProductPrice>() { productPrice } : new List<ProductPrice>();
        }

        public Price(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ICollection<ProductPrice> productPrice)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice;
        }
    }
}
