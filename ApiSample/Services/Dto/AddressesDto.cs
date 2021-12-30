using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class AddressesDto : ModelDto
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public StatesDto State { get; set; }
        public int PostalCode { get; set; }
        public string? Complement { get; set; }

        public static implicit operator Addresses(AddressesDto address)
        {
            return new()
            {
                Street = address.Street,
                Number = address.Number,
                City = address.City,
                State = (States)address.State,
                PostalCode = address.PostalCode,
                Complement = address.Complement
            };
        }

        public AddressesDto()
        {
            Street = string.Empty;
            Number = string.Empty;
            City = string.Empty;
            State = StatesDto.AC;
            PostalCode = 10000000;
            Complement = string.Empty;
        }

        public AddressesDto(string street, string number, string city, StatesDto state, int postalCode, string? complement = null)
        {
            Street = street;
            Number = number;
            City = city;
            State = state;
            PostalCode = postalCode;
            Complement = complement ?? string.Empty;
        }
    }
}
