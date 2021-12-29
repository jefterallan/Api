using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Model
    {
        ICollection<T> Get();
        IAsyncEnumerable<T> Create(T entity);
        IAsyncEnumerable<T> Edit(T entity);
        IAsyncEnumerable<T?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(T entity);

    }
}
