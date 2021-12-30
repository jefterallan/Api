using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        ICollection<Orders> Get();
        IAsyncEnumerable<Orders> Create(Orders entity);
        IAsyncEnumerable<Orders> Edit(Orders entity);
        IAsyncEnumerable<Orders?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Orders entity);
    }
}
