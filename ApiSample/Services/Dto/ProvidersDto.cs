using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class ProvidersDto : PersonDto
    {
        public string CorporateName { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? OpeningDate { get; set; }

        public static implicit operator Providers(ProvidersDto provider)
        {
            return new()
            {
                CorporateName = provider.CorporateName,
                Cnpj = provider.Cnpj,
                OpeningDate = provider.OpeningDate
            };
        }

        public ProvidersDto()
        {
            CorporateName = string.Empty;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public ProvidersDto(string corporateName)
        {
            CorporateName = corporateName;
            Cnpj = string.Empty;
            OpeningDate = DateTime.Now;
        }

        public ProvidersDto(string corporateName, string? cnpj, DateTime? openingDate)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }

        public ProvidersDto(string corporateName, string? cnpj, DateTime? openingDate, string name, string mobilePhone, AddressesDto address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }

        public ProvidersDto(string corporateName, string? cnpj, DateTime? openingDate, string name, string mobilePhone, ICollection<AddressesDto> address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            CorporateName = corporateName;
            Cnpj = cnpj;
            OpeningDate = openingDate;
        }
    }
}
