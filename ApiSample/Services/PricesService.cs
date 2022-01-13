using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class PricesService : Service, IPricesService
    {
        private readonly IPricesRepository PricesRepository;

        public PricesService(ILogger<PricesService> logger,
            IMapper mapper,
            INotifier notifier,
            IPricesRepository pricesRepository)
            : base(logger, mapper, notifier)
        {
            PricesRepository = pricesRepository;
        }

        public async Task<PricesDto> Create(PricesDto price)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PricesDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PricesDto> Edit(PricesDto price)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<PricesDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
