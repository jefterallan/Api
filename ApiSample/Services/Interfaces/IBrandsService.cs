using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IBrandsService
    {
        Task<ICollection<Brands>> Get();
        Task<Brands> Create(Brands brand);
        Task<Brands> Edit(Brands brand);
        Task<Brands?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Brands brand);
    }
}
