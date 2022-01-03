namespace ApiSample.Data.Models
{
    public class Person : Model
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string MobilePhone { get; set; }
        
        public virtual ICollection<Addresses> Address { get; set; }

        public Person()
        {
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            MobilePhone = string.Empty;
            Address = new List<Addresses>();
        }

        public Person(string name, string mobilePhone, Addresses address, string? email = null, string? phone = null)
        {
            Name = name;
            MobilePhone = mobilePhone;
            Address = new List<Addresses>() { address };
            Email = email ?? string.Empty;
            Phone = phone ?? string.Empty;
        }

        public Person(string name, string mobilePhone, ICollection<Addresses> address, string? email = null, string? phone = null)
        {
            Name = name;
            MobilePhone = mobilePhone;
            Address = address;
            Email = email ?? string.Empty;
            Phone = phone ?? string.Empty;
        }
    }
}
