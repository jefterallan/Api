using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class UsersDto : CredentialDto
    {
        public string Name { get; set; }
        public GroupsDto Group { get; set; }

        public static implicit operator Users(UsersDto user)
        {
            return new()
            {
                Name = user.Name,
                Group = user.Group,
            };
        }

        public UsersDto()
        {
            Name = string.Empty;
            Group = new();
        }

        public UsersDto(string name, GroupsDto type)
        {
            Name = name;
            Group = type;
        }

        public UsersDto(string name, GroupsDto group, string username, string password)
            : base(username, password)
        {
            Name = name;
            Group = group;
        }
    }
}
