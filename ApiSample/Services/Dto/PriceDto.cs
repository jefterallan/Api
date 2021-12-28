using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class PriceDto : ModelDto
    {
        public decimal Cost { get; set; }
        public decimal Sell { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public ICollection<ProductPriceDto> ProductPrice { get; set; }

        public static implicit operator Price(PriceDto price)
        {
            return new()
            {
                Cost = price.Cost,
                Sell = price.Sell,
                InitialDate = price.InitialDate,
                FinalDate = price.FinalDate,
                ProductPrice = price.ProductPrice.Select<ProductPriceDto, ProductPrice>(x => x).ToList(),
            };
        }

        public PriceDto()
        {
            Cost = 0;
            Sell = 0;
            InitialDate = DateTime.Today;
            FinalDate = DateTime.Today.AddDays(1);
            ProductPrice = new List<ProductPriceDto>();
        }

        public PriceDto(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ProductPriceDto? productPrice = null)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice != null ? new List<ProductPriceDto>() { productPrice } : new List<ProductPriceDto>();
        }

        public PriceDto(decimal cost, decimal sell, DateTime initialDate, DateTime finalDate, ICollection<ProductPriceDto> productPrice)
        {
            Cost = cost;
            Sell = sell;
            InitialDate = initialDate;
            FinalDate = finalDate;
            ProductPrice = productPrice;
        }
    }
}
