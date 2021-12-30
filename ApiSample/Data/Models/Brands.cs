namespace ApiSample.Data.Models
{
    public class Brands : Model
    {
        public string Description { get; set; }

        public ICollection<Products>? Products { get; set; }

        public Brands()
        {
            Description = string.Empty;
        }

        public Brands(string description)
        {
            Description = description;
        }

        public Brands(string description, Products product)
        {
            Description = description;
            Products = new List<Products>() { product };
        }
    }
}
