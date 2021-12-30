using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class PersonDto : ModelDto
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string MobilePhone { get; set; }

        public ICollection<AddressesDto> Address { get; set; }

        public static implicit operator Person(PersonDto person)
        {
            return new()
            {
                Name = person.Name,
                Email = person.Email,
                Phone = person.Phone,
                MobilePhone = person.MobilePhone,
                Address = person.Address.Select<AddressesDto, Addresses>(x => x).ToList()
            };
        }

        public PersonDto()
        {
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            MobilePhone = string.Empty;
            Address = new List<AddressesDto>();
        }

        public PersonDto(string name, string mobilePhone, AddressesDto address, string? email = null, string? phone = null)
        {
            Name = name;
            MobilePhone = mobilePhone;
            Address = new List<AddressesDto>() { address };
            Email = email ?? string.Empty;
            Phone = phone ?? string.Empty;
        }

        public PersonDto(string name, string mobilePhone, ICollection<AddressesDto> address, string? email = null, string? phone = null)
        {
            Name = name;
            MobilePhone = mobilePhone;
            Address = address;
            Email = email ?? string.Empty;
            Phone = phone ?? string.Empty;
        }
    }
}
