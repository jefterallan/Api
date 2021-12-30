using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IProductPricesRepository
    {
        ICollection<ProductPrices> Get();
        IAsyncEnumerable<ProductPrices> Create(ProductPrices entity);
        IAsyncEnumerable<ProductPrices> Edit(ProductPrices entity);
        IAsyncEnumerable<ProductPrices?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(ProductPrices entity);
    }
}
