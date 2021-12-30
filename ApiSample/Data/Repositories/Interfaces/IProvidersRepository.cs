using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IProvidersRepository
    {
        ICollection<Providers> Get();
        IAsyncEnumerable<Providers> Create(Providers entity);
        IAsyncEnumerable<Providers> Edit(Providers entity);
        IAsyncEnumerable<Providers?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Providers entity);
    }
}
