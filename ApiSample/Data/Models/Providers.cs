namespace ApiSample.Data.Models
{
    public class Providers : Person
    {
        public string CorporateName { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? OpeningDate { get; set; }

        public Providers()
        {
            CorporateName = string.Empty;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public Providers(string corporateName)
        {
            CorporateName = corporateName;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public Providers(string corporateName, string? cnpj, DateTime? openingDate)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }

        public Providers(string corporateName, string? cnpj, DateTime? openingDate, string name, string mobilePhone, Addresses address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }

        public Providers(string corporateName, string? cnpj, DateTime? openingDate, string name, string mobilePhone, ICollection<Addresses> address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }
    }
}
