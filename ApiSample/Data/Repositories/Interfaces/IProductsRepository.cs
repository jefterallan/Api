using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IProductsRepository
    {
        Task<IList<Products>> Get();
        Task<Products> Create(Products entity);
        Task<Products> Edit(Products entity);
        Task<Products?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Products entity);
    }
}
