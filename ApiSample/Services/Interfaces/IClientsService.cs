using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IClientsService
    {
        Task<IList<Clients>> Get();
        Task<Clients> Create(Clients client);
        Task<Clients> Edit(Clients client);
        Task<Clients?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Clients client);
    }
}
