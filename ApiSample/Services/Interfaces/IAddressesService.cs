using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IAddressesService
    {
        Task<ICollection<Addresses>> Get();
        Task<Addresses> Create(Addresses address);
        Task<Addresses> Edit(Addresses address);
        Task<Addresses?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Addresses address);
    }
}
