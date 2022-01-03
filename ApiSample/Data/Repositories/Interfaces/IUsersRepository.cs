using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<IList<Users>> Get();
        Task<Users> Create(Users entity);
        Task<Users> Edit(Users entity);
        Task<Users?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Users entity);
    }
}
