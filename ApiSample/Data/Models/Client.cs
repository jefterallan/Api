using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class Client : Person
    {
        public string? Cpf { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BirthDate { get; set; }

        public Client()
        {
            Cpf = string.Empty;
            Gender = Gender.Male;
            BirthDate = DateTime.Now;
        }

        public Client(string? cpf, Gender gender, DateTime? birthDate)
        {
            Cpf = cpf;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
