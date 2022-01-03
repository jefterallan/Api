using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IProvidersRepository
    {
        Task<IList<Providers>> Get();
        Task<Providers> Create(Providers entity);
        Task<Providers> Edit(Providers entity);
        Task<Providers?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Providers entity);
    }
}
