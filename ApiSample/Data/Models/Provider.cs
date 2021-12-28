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
    }
}
