using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class UserDto : CredentialDto
    {
        public string Name { get; set; }
        public GroupDto Group { get; set; }

        public static implicit operator User(UserDto user)
        {
            return new()
            {
                Name = user.Name,
                Group = user.Group,
            };
        }

        public UserDto()
        {
            Name = string.Empty;
            Group = new();
        }

        public UserDto(string name, GroupDto type)
        {
            Name = name;
            Group = type;
        }

        public UserDto(string name, GroupDto group, string username, string password)
            : base(username, password)
        {
            Name = name;
            Group = group;
        }
    }
}
