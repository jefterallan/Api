namespace ApiSample.Data.Models
{
    public class ProductPrices : Model
    {
        public Products Product { get; set;}
        public Prices Price { get; set;}

        public ProductPrices()
        {
            Product = new Products();
            Price = new Prices();
        }

        public ProductPrices(Products product, Prices price)
        {
            Product = product;
            Price = price;
        }
    }
}
