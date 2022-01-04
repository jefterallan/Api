using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class GroupsDto : ModelDto
    {
        public string Name { get; set; }

        public static implicit operator Groups(GroupsDto group)
        {
            return new()
            {
                Name = group.Name
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

        public override string ToString()
        {
            return Name;
        }
    }
}
