namespace ApiSample.Data.Models
{
    public class Brand : Model
    {
        public string Description { get; set; }

        public ICollection<Product>? Products { get; set; }

        public Brand()
        {
            Description = string.Empty;
        }

        public Brand(string description)
        {
            Description = description;
        }

        public Brand(string description, Product product)
        {
            Description = description;
            Products = new List<Product>() { product };
        }
    }
}
