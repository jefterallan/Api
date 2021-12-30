using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class Clients : Person
    {
        public string? Cpf { get; set; }
        public Genders Gender { get; set; }
        public DateTime? BirthDate { get; set; }

        public Clients()
        {
            Cpf = string.Empty;
            Gender = Genders.Male;
            BirthDate = DateTime.Now;
        }

        public Clients(string? cpf, Genders gender, DateTime? birthDate)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }

        public Clients(string? cpf, Genders gender, DateTime? birthDate, string name, string mobilePhone, Addresses address, string? email = null, string? phone = null) 
            : base(name, mobilePhone, address, email, phone)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }

        public Clients(string? cpf, Genders gender, DateTime? birthDate, string name, string mobilePhone, ICollection<Addresses> address, string? email = null, string? phone = null)
            : base(name, mobilePhone, address, email, phone)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
