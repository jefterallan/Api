namespace ApiSample.Services.Dto
{
    public class CredentialDto : ModelDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

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
