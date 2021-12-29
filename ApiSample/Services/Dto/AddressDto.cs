using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class AddressDto : ModelDto
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public StateDto State { get; set; }
        public int PostalCode { get; set; }
        public string? Complement { get; set; }

        public static implicit operator Address(AddressDto address)
        {
            return new()
            {
                Street = address.Street,
                Number = address.Number,
                City = address.City,
                State = (State)address.State,
                PostalCode = address.PostalCode,
                Complement = address.Complement
            };
        }

        public AddressDto()
        {
            Street = string.Empty;
            Number = string.Empty;
            City = string.Empty;
            State = StateDto.AC;
            PostalCode = 10000000;
            Complement = string.Empty;
        }

        public AddressDto(string street, string number, string city, StateDto state, int postalCode, string? complement = null)
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
