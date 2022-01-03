using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class PricesService : Service<PricesService>, IPricesService
    {
        private readonly IPricesRepository PricesRepository;

        public PricesService(INotifier notifier,
            ILogger<PricesService> logger,
            IMapper mapper,
            IPricesRepository pricesRepository)
            : base(notifier, logger, mapper)
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

        public Task<IList<Prices>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
