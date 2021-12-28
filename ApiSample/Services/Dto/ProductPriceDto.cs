using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class ProductPriceDto : ModelDto
    {
        public ProductDto Product { get; set; }
        public PriceDto Price { get; set; }

        public static implicit operator ProductPrice(ProductPriceDto productPrice)
        {
            return new()
            {
                Product = productPrice.Product,
                Price = productPrice.Price
            };
        }
            
        public ProductPriceDto()
        {
            Product = new ProductDto();
            Price = new PriceDto();
        }

        public ProductPriceDto(ProductDto product, PriceDto price)
        {
            Product = product;
            Price = price;
        }
    }
}
