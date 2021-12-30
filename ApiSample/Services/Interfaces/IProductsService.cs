using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IProductsService
    {
        Task<ICollection<Products>> Get();
        Task<Products> Create(Products product);
        Task<Products> Edit(Products product);
        Task<Products?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Products product);
    }
}
