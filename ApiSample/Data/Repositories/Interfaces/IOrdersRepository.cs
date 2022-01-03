using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        Task<IList<Orders>> Get();
        Task<Orders> Create(Orders entity);
        Task<Orders> Edit(Orders entity);
        Task<Orders?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Orders entity);
    }
}
