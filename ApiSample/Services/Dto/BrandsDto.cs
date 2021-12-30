using ApiSample.Data.Models;
using System.Linq;

namespace ApiSample.Services.Dto
{
    public class BrandsDto : ModelDto
    {
        public string Description { get; set; }

        public ICollection<ProductsDto>? Products { get; set; }

        public static implicit operator Brands(BrandsDto address)
        {
            return new()
            {
                Description = address.Description,
                Products = address.Products?.Select<ProductsDto, Products>(x => x).ToList()
            };
        }

        public BrandsDto()
        {
            Description = string.Empty;
        }

        public BrandsDto(string description)
        {
            Description = description;
        }

        public BrandsDto(string description, ProductsDto product)
        {
            Description = description;
            Products = new List<ProductsDto>() { product };
        }
    }
}
