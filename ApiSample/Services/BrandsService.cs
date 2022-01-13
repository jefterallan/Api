using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class BrandsService : Service, IBrandsService
    {
        private readonly IBrandsRepository BrandsRepository;

        public BrandsService(ILogger<BrandsService> logger,
            IMapper mapper,
            INotifier notifier, 
            IBrandsRepository brandsRepository)
            : base(logger, mapper, notifier)
        {
            BrandsRepository = brandsRepository;
        }

        public async Task<BrandsDto> Create(BrandsDto brand)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<BrandsDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<BrandsDto> Edit(BrandsDto brand)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<BrandsDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
