using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
