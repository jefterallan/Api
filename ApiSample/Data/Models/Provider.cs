namespace ApiSample.Data.Models
{
    public class Provider : Person
    {
        public string CorporateName { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? OpeningDate { get; set; }

        public Provider()
        {
            CorporateName = string.Empty;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public Provider(string corporateName)
        {
            CorporateName = corporateName;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public Provider(string corporateName, string? cnpj, DateTime? openingDate)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }

        public Provider(string corporateName, string? cnpj, DateTime? openingDate, string name, string mobilePhone, Address address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }

        public Provider(string corporateName, string? cnpj, DateTime? openingDate, string name, string mobilePhone, ICollection<Address> address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }
    }
}
