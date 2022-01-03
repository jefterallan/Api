using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IProductPricesService
    {
        Task<IList<ProductPrices>> Get();
        Task<ProductPrices> Create(ProductPrices productPrice);
        Task<ProductPrices> Edit(ProductPrices productPrice);
        Task<ProductPrices?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(ProductPrices productPrice);
    }
}
