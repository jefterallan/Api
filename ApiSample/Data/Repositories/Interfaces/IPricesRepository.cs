using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IPricesRepository
    {
        Task<IList<Prices>> Get();
        Task<Prices> Create(Prices entity);
        Task<Prices> Edit(Prices entity);
        Task<Prices?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Prices entity);
    }
}
