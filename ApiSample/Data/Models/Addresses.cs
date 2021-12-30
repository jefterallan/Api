using ApiSample.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace ApiSample.Data.Models
{
    public class Addresses : Model
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public States State { get; set; }

        [Range(8, 8)]
        public int PostalCode { get; set; }
        public string? Complement { get; set; }

        public Clients? Client { get; set; }
        public Providers? Provider { get; set; }

        public Addresses()
        {
            Street = string.Empty;
            Number = string.Empty;
            City = string.Empty;
            State = States.AC;
            PostalCode = 10000000;
            Complement = string.Empty;
        }

        public Addresses(string street, string number, string city, States state, int postalCode, string? complement = null)
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
