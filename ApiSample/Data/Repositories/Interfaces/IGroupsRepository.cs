using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IGroupsRepository
    {
        ICollection<Groups> Get();
        IAsyncEnumerable<Groups> Create(Groups entity);
        IAsyncEnumerable<Groups> Edit(Groups entity);
        IAsyncEnumerable<Groups?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Groups entity);
    }
}
