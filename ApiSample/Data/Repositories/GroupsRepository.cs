using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class GroupsRepository : Repository<Groups>, IGroupsRepository
    {
        public GroupsRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
