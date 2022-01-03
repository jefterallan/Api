using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IOrdersService
    {
        Task<IList<Orders>> Get();
        Task<Orders> Create(Orders order);
        Task<Orders> Edit(Orders order);
        Task<Orders?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Orders order);
    }
}
