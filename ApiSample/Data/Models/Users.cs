namespace ApiSample.Data.Models
{
    public class Users : Credential
    {
        public string Name { get; set; }

        public virtual Groups Group { get; set; }

        public Users()
        {
            Name = string.Empty;
            Group = new Groups();
        }

        public Users(string name, Groups group)
        {
            Name = name;
            Group = group;
        }

        public Users(string name, Groups group, string username, string password)
            : base(username, password)
        {
            Name = name;
            Group = group;
        }
    }
}
