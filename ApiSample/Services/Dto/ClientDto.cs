using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class ClientDto : PersonDto
    {
        public string? Cpf { get; set; }
        public GenderDto Gender { get; set; }
        public DateTime? BirthDate { get; set; }

        public static implicit operator Client(ClientDto client)
        {
            return new()
            {
                Cpf = client.Cpf,
                Gender = (Gender)client.Gender,
                BirthDate = client.BirthDate,
            };
        }

        public ClientDto()
        {
            Cpf = string.Empty;
            Gender = GenderDto.Male;
            BirthDate = DateTime.Now;
        }

        public ClientDto(string? cpf, GenderDto gender, DateTime? birthDate)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }

        public ClientDto(string? cpf, GenderDto gender, DateTime? birthDate, string name, string mobilePhone, AddressDto address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }

        public ClientDto(string? cpf, GenderDto gender, DateTime? birthDate, string name, string mobilePhone, ICollection<AddressDto> address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
