using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class ProductPricesDto : ModelDto
    {
        public ProductsDto Product { get; set; }
        public PricesDto Price { get; set; }

        public static implicit operator ProductPrices(ProductPricesDto productPrice)
        {
            return new()
            {
                Product = productPrice.Product,
                Price = productPrice.Price
            };
        }
            
        public ProductPricesDto()
        {
            Product = new ProductsDto();
            Price = new PricesDto();
        }

        public ProductPricesDto(ProductsDto product, PricesDto price)
        {
            Product = product;
            Price = price;
        }
    }
}
