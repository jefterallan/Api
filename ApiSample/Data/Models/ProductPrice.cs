namespace ApiSample.Data.Models
{
    public class ProductPrice : Model
    {
        public Product Product { get; set;}
        public Price Price { get; set;}

        public ProductPrice()
        {
            Product = new Product();
            Price = new Price();
        }

        public ProductPrice(Product product, Price price)
        {
            Product = product;
            Price = price;
        }
    }
}
