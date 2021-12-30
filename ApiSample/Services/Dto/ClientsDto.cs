using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class ClientsDto : PersonDto
    {
        public string? Cpf { get; set; }
        public GendersDto Gender { get; set; }
        public DateTime? BirthDate { get; set; }

        public static implicit operator Clients(ClientsDto client)
        {
            return new()
            {
                Cpf = client.Cpf,
                Gender = (Genders)client.Gender,
                BirthDate = client.BirthDate,
            };
        }

        public ClientsDto()
        {
            Cpf = string.Empty;
            Gender = GendersDto.Male;
            BirthDate = DateTime.Now;
        }

        public ClientsDto(string? cpf, GendersDto gender, DateTime? birthDate)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }

        public ClientsDto(string? cpf, GendersDto gender, DateTime? birthDate, string name, string mobilePhone, AddressesDto address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }

        public ClientsDto(string? cpf, GendersDto gender, DateTime? birthDate, string name, string mobilePhone, ICollection<AddressesDto> address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
