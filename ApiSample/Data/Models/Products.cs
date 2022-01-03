namespace ApiSample.Data.Models
{
    public class Products : Model
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public virtual Brands Brand { get; set; }
        public virtual ICollection<ProductPrices> ProductPrice { get; set; }

        public Products()
        {
            Code = string.Empty;
            Description = string.Empty;
            Amount = 0;
            Brand = new Brands();
            ProductPrice = new List<ProductPrices>();
        }

        public Products(string code, string description, int amount, Brands brand, ProductPrices? productPrice = null)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice != null ? new List<ProductPrices>() { productPrice } : new List<ProductPrices>();
        }

        public Products(string code, string description, int amount, Brands brand, ICollection<ProductPrices> productPrice)
        {
            Code = code;
            Description = description;
            Amount = amount;
            Brand = brand;
            ProductPrice = productPrice;
        }
    }
}
