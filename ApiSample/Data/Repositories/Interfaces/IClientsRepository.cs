using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IClientsRepository
    {
        ICollection<Clients> Get();
        IAsyncEnumerable<Clients> Create(Clients entity);
        IAsyncEnumerable<Clients> Edit(Clients entity);
        IAsyncEnumerable<Clients?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Clients entity);
    }
}
