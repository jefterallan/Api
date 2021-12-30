using ApiSample.Data.Models;
using ApiSample.Data.Repositories;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class PricesService : Service<PricesService>, IPricesService
    {
        private readonly PricesRepository PricesRepository;

        public PricesService(INotifier notifier,
            ILogger<PricesService> logger,
            PricesRepository pricesRepository)
            : base(notifier, logger)
        {
            PricesRepository = pricesRepository;
        }

        public Task<Prices> Create(Prices price)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Prices price)
        {
            throw new NotImplementedException();
        }

        public Task<Prices?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Prices> Edit(Prices price)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Prices>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
