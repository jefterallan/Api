using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IPricesRepository
    {
        ICollection<Prices> Get();
        IAsyncEnumerable<Prices> Create(Prices entity);
        IAsyncEnumerable<Prices> Edit(Prices entity);
        IAsyncEnumerable<Prices?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Prices entity);
    }
}
