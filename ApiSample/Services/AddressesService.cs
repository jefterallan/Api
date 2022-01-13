using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class AddressesService : Service, IAddressesService
    {
        private readonly IAddressesRepository AddressesRepository;

        public AddressesService(ILogger<AddressesService> logger,
            IMapper mapper,
            INotifier notifier,
            IAddressesRepository addressesRepository)
            : base(logger, mapper, notifier)
        {
            AddressesRepository = addressesRepository;
        }

        public async Task<AddressesDto> Create(AddressesDto address)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(AddressesDto address)
        {
            throw new NotImplementedException();
        }

        public async Task<AddressesDto?> Details(Guid id)
        {
            var result = await AddressesRepository.Details(id);

            return Mapper.Map<AddressesDto>(result);
        }

        public async Task<AddressesDto> Edit(AddressesDto address)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<AddressesDto>> Get()
        {
            var result = await AddressesRepository.Get();

            return Mapper.Map<IList<AddressesDto>>(result);
        }
    }
}
