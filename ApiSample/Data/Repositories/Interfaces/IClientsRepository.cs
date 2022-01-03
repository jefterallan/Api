using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IClientsRepository
    {
        Task<IList<Clients>> Get();
        Task<Clients> Create(Clients entity);
        Task<Clients> Edit(Clients entity);
        Task<Clients?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Clients entity);
    }
}
