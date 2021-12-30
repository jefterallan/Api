using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IGroupsService
    {
        Task<ICollection<Groups>> Get();
        Task<Groups> Create(Groups group);
        Task<Groups> Edit(Groups group);
        Task<Groups?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Groups group);
    }
}
