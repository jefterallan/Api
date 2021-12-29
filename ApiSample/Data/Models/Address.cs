using ApiSample.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace ApiSample.Data.Models
{
    public class Address : Model
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public State State { get; set; }

        [Range(8, 8)]
        public int PostalCode { get; set; }
        public string? Complement { get; set; }

        public Client? Client { get; set; }
        public Provider? Provider { get; set; }

        public Address()
        {
            Street = string.Empty;
            Number = string.Empty;
            City = string.Empty;
            State = State.AC;
            PostalCode = 10000000;
            Complement = string.Empty;
        }

        public Address(string street, string number, string city, State state, int postalCode, string? complement = null)
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
