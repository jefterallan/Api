using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class PricesDto : ModelDto
    {
        public decimal Cost { get; set; }
        public decimal Sell { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public ICollection<ProductPricesDto> ProductPrice { get; set; }

        public static implicit operator Prices(PricesDto price)
        {
            return new()
            {
                Cost = price.Cost,
                Sell = price.Sell,
                InitialDate = price.InitialDate,
                FinalDate = price.FinalDate,
                ProductPrice = price.ProductPrice.Select<ProductPricesDto, ProductPrices>(x => x).ToList(),
            };
        }

        public PricesDto()
        {
            Cost = 0;
            Sell = 0;
            InitialDate = DateTime.Today;
            FinalDate = DateTime.Today.AddDays(1);
            ProductPrice = new List<ProductPricesDto>();
        }

        public PricesDto(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ProductPricesDto? productPrice = null)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice != null ? new List<ProductPricesDto>() { productPrice } : new List<ProductPricesDto>();
        }

        public PricesDto(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ICollection<ProductPricesDto> productPrice)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice;
        }
    }
}
