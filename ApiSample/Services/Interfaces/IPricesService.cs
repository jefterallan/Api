using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IPricesService
    {
        Task<ICollection<Prices>> Get();
        Task<Prices> Create(Prices price);
        Task<Prices> Edit(Prices price);
        Task<Prices?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Prices price);
    }
}
