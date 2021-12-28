using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class ProductDto : ModelDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public BrandDto Brand { get; set; }
        public ICollection<ProductPriceDto> ProductPrice { get; set; }

        public static implicit operator Product(ProductDto product)
        {
            return new()
            {
                Code = product.Code,
                Description = product.Description,
                Amount = product.Amount,
                Brand = product.Brand,
                ProductPrice = product.ProductPrice.Select<ProductPriceDto, ProductPrice>(x => x).ToList()
            };
        }

        public ProductDto()
        {
            Code = string.Empty;
            Description = string.Empty;
            Amount = 0;
            Brand = new BrandDto();
            ProductPrice = new List<ProductPriceDto>();
        }

        public ProductDto(string code, string description, int amount, BrandDto brand, ProductPriceDto? productPrice = null)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice != null ? new List<ProductPriceDto>() { productPrice } : new List<ProductPriceDto>();
        }

        public ProductDto(string code, string description, int amount, BrandDto brand, ICollection<ProductPriceDto> productPrice)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice;
        }
    }
}
