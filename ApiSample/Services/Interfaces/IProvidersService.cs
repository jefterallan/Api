using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IProvidersService
    {
        Task<IList<Providers>> Get();
        Task<Providers> Create(Providers provider);
        Task<Providers> Edit(Providers provider);
        Task<Providers?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Providers provider);
    }
}
