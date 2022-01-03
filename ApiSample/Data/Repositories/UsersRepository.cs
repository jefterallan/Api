using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSample.Data.Repositories
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(ApiSampleContext context) : base(context)
        {
        }

        public async Task<Users?> FindApiCredentials(Credential credential)
        {
            return await Context.Users.Include(u => u.Group)
                .FirstOrDefaultAsync(u => u .Active &&
                                    u.Username == credential.Username &&
                                    u.Password  == credential.Password);
        }
    }
}
