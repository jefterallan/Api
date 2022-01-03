using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class AddressesService : Service<AddressesService>, IAddressesService
    {
        private readonly IAddressesRepository AddressesRepository;

        public AddressesService(INotifier notifier,
            ILogger<AddressesService> logger,
            IMapper mapper,
            IAddressesRepository addressesRepository)
            : base(notifier, logger, mapper)
        {
            AddressesRepository = addressesRepository;
        }

        public Task<Addresses> Create(Addresses address)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Addresses address)
        {
            throw new NotImplementedException();
        }

        public async Task<Addresses?> Details(Guid id)
        {
            return await AddressesRepository.Details(id);
        }

        public Task<Addresses> Edit(Addresses address)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Addresses>> Get()
        {
            return await AddressesRepository.Get();
        }
    }
}
