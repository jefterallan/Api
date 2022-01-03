using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IAddressesRepository
    {
        Task<IList<Addresses>> Get();
        Task<Addresses> Create(Addresses entity);
        Task<Addresses> Edit(Addresses entity);
        Task<Addresses?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Addresses entity);
    }
}
