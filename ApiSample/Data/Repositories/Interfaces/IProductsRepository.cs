using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IProductsRepository
    {
        ICollection<Products> Get();
        IAsyncEnumerable<Products> Create(Products entity);
        IAsyncEnumerable<Products> Edit(Products entity);
        IAsyncEnumerable<Products?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Products entity);
    }
}
