using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IGroupsRepository
    {
        Task<IList<Groups>> Get();
        Task<Groups> Create(Groups entity);
        Task<Groups> Edit(Groups entity);
        Task<Groups?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Groups entity);
    }
}
