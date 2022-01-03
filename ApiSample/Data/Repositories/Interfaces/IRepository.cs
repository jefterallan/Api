using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Model
    {
        Task<IList<T>> Get();
        Task<T> Create(T entity);
        Task<T> Edit(T entity);
        Task<T?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(T entity);
    }
}
