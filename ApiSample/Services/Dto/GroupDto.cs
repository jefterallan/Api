using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class GroupDto : ModelDto
    {
        public string Name { get; set; }

        public static implicit operator Group(GroupDto group)
        {
            return new()
            {
                Name = group.Name
            };
        }

        public GroupDto()
        {
            Name = string.Empty;
        }

        public GroupDto(string name)
        {
            Name = name;
        }
    }
}
