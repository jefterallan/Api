namespace ApiSample.Data.Models
{
    public class Credential : Model
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Credential()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
        public Credential(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
