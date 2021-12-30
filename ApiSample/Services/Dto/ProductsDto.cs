using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class ProductsDto : ModelDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public BrandsDto Brand { get; set; }
        public ICollection<ProductPricesDto> ProductPrice { get; set; }

        public static implicit operator Products(ProductsDto product)
        {
            return new()
            {
                Code = product.Code,
                Description = product.Description,
                Amount = product.Amount,
                Brand = product.Brand,
                ProductPrice = product.ProductPrice.Select<ProductPricesDto, ProductPrices>(x => x).ToList()
            };
        }

        public ProductsDto()
        {
            Code = string.Empty;
            Description = string.Empty;
            Amount = 0;
            Brand = new BrandsDto();
            ProductPrice = new List<ProductPricesDto>();
        }

        public ProductsDto(string code, string description, int amount, BrandsDto brand, ProductPricesDto? productPrice = null)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice != null ? new List<ProductPricesDto>() { productPrice } : new List<ProductPricesDto>();
        }

        public ProductsDto(string code, string description, int amount, BrandsDto brand, ICollection<ProductPricesDto> productPrice)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice;
        }
    }
}
