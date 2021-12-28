using ApiSample.Data.Models;
using System.Linq;

namespace ApiSample.Services.Dto
{
    public class BrandDto : ModelDto
    {
        public string Description { get; set; }

        public ICollection<ProductDto>? Products { get; set; }

        public static implicit operator Brand(BrandDto address)
        {
            return new()
            {
                Description = address.Description,
                Products = address.Products?.Select<ProductDto, Product>(x => x).ToList()
            };
        }

        public BrandDto()
        {
            Description = string.Empty;
        }

        public BrandDto(string description)
        {
            Description = description;
        }

        public BrandDto(string description, ProductDto product)
        {
            Description = description;
            Products = new List<ProductDto>() { product };
        }
    }
}
