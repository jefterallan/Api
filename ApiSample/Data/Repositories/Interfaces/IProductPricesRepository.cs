using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IProductPricesRepository
    {
        Task<IList<ProductPrices>> Get();
        Task<ProductPrices> Create(ProductPrices entity);
        Task<ProductPrices> Edit(ProductPrices entity);
        Task<ProductPrices?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(ProductPrices entity);
    }
}
