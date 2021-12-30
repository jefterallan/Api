namespace ApiSample.Data.Models
{
    public class Groups : Model
    {
        public string Name { get; set; }

        public ICollection<Users>? Users { get; set; }

        public Groups()
        {
            Name = string.Empty;
        }

        public Groups(string name)
        {
            Name = name;
        }

        public Groups(string name, Users users)
        {
            Name = name;
            Users = new List<Users>() { users };
        }

        public Groups(string name, ICollection<Users>? users)
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
