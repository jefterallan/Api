using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IAddressesRepository
    {
        ICollection<Addresses> Get();
        IAsyncEnumerable<Addresses> Create(Addresses entity);
        IAsyncEnumerable<Addresses> Edit(Addresses entity);
        IAsyncEnumerable<Addresses?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Addresses entity);
    }
}
