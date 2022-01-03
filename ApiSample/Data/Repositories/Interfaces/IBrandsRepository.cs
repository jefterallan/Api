using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IBrandsRepository
    {
        Task<IList<Brands>> Get();
        Task<Brands> Create(Brands entity);
        Task<Brands> Edit(Brands entity);
        Task<Brands?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Brands entity);
    }
}
