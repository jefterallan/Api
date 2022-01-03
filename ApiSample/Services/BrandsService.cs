using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class BrandsService : Service<BrandsService>, IBrandsService
    {
        private readonly IBrandsRepository BrandsRepository;

        public BrandsService(INotifier notifier,
            ILogger<BrandsService> logger,
            IMapper mapper,
            IBrandsRepository brandsRepository)
            : base(notifier, logger, mapper)
        {
            BrandsRepository = brandsRepository;
        }

        public Task<Brands> Create(Brands brand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Brands brand)
        {
            throw new NotImplementedException();
        }

        public Task<Brands?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Brands> Edit(Brands brand)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Brands>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
