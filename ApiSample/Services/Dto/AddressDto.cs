using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class AddressDto : ModelDto
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string? Complement { get; set; }

        public static implicit operator Address(AddressDto address)
        {
            return new()
            {
                Street = address.Street,
                Number = address.Number,
                City = address.City,
                State = address.State,
                PostalCode = address.PostalCode,
                Complement = address.Complement
            };
        }

        public AddressDto()
        {
            Street = string.Empty;
            Number = string.Empty;
            City = string.Empty;
            State = string.Empty;
            PostalCode = 10000000;
            Complement = string.Empty;
        }

        public AddressDto(string street, string number, string city, string state, int postalCode, string? complement = null)
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
