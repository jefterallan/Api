using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class CredentialDto : ModelDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static implicit operator Credential(CredentialDto credential)
        {
            return new()
            {
                Username = credential.Username,
                Password = credential.Password               
            };
        }

        public CredentialDto()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        public CredentialDto(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
