using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        ICollection<Users> Get();
        IAsyncEnumerable<Users> Create(Users entity);
        IAsyncEnumerable<Users> Edit(Users entity);
        IAsyncEnumerable<Users?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Users entity);
    }
}
