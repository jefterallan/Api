using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class ProviderDto : PersonDto
    {
        public string CorporateName { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? OpeningDate { get; set; }

        public static implicit operator Provider(ProviderDto provider)
        {
            return new()
            {
                CorporateName = provider.CorporateName,
                Cnpj = provider.Cnpj,
                OpeningDate = provider.OpeningDate
            };
        }

        public ProviderDto()
        {
            CorporateName = string.Empty;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public ProviderDto(string corporateName)
        {
            CorporateName = corporateName;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public ProviderDto(string corporateName, string? cnpj, DateTime? openingDate)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }
    }
}
