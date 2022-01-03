namespace ApiSample.Data.Models
{
    public class ProductPrices : Model
    {
        public virtual Products Product { get; set;}
        public virtual Prices Price { get; set;}

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
