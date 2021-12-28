namespace ApiSample.Data.Models
{
    public class Group : Model
    {
        public string Name { get; set; }

        public ICollection<User>? Users { get; set; }

        public Group()
        {
            Name = string.Empty;
        }

        public Group(string name)
        {
            Name = name;
        }

        public Group(string name, User users)
        {
            Name = name;
            Users = new List<User>() { users };
        }

        public Group(string name, ICollection<User>? users)
        {
            Name = name;
            Users = users;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
