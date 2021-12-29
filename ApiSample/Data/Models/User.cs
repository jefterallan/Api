namespace ApiSample.Data.Models
{
    public class User : Credential
    {
        public string Name { get; set; }

        public Group Group { get; set; }

        public User()
        {
            Name = string.Empty;
            Group = new Group();
        }

        public User(string name, Group group)
        {
            Name = name;
            Group = group;
        }

        public User(string name, Group group, string username, string password)
            : base(username, password)
        {
            Name = name;
            Group = group;
        }
    }
}
