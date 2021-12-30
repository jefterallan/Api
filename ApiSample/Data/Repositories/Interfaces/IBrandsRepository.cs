using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IBrandsRepository
    {
        ICollection<Brands> Get();
        IAsyncEnumerable<Brands> Create(Brands entity);
        IAsyncEnumerable<Brands> Edit(Brands entity);
        IAsyncEnumerable<Brands?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Brands entity);
    }
}
