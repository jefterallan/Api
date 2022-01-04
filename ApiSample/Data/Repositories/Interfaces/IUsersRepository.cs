using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IUsersRepository : IRepository<Users>
    {
        Task<Users?> FindApiCredentials(Credential credential);
    }
}
