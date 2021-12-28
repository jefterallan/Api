namespace ApiSample.Data.Models
{
    public class Product : Model
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public Brand Brand { get; set; }
        public ICollection<ProductPrice> ProductPrice { get; set; }

        public Product()
        {
            Code = string.Empty;
            Description = string.Empty;
            Amount = 0;
            Brand = new Brand();
            ProductPrice = new List<ProductPrice>();
        }

        public Product(string code, string description, int amount, Brand brand, ProductPrice? productPrice = null)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice != null ? new List<ProductPrice>() { productPrice } : new List<ProductPrice>();
        }

        public Product(string code, string description, int amount, Brand brand, ICollection<ProductPrice> productPrice)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice;
        }
    }
}
