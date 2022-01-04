using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Model
    {
        abstract Task<IList<T>> Get();
        abstract Task<T> Create(T entity);
        abstract Task<T> Edit(T entity);
        abstract Task<T?> Details(Guid id);
        abstract Task<bool> Delete(Guid id);
        abstract Task<bool> Delete(T entity);
    }
}
