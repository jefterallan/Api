using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class GroupsDto : ModelDto
    {
        public string Name { get; set; }

        public ICollection<UsersDto>? Users { get; set; }

        public static implicit operator Groups(GroupsDto group)
        {
            return new()
            {
                Name = group.Name,
                Users = group.Users?.Select<UsersDto, Users>(x => x).ToList()
            };
        }

        public GroupsDto()
        {
            Name = string.Empty;
        }

        public GroupsDto(string name)
        {
            Name = name;
        }

        public GroupsDto(string name, ICollection<UsersDto>? users)
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
