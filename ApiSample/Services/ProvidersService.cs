using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class ProvidersService : Service<ProvidersService>, IProvidersService
    {
        private readonly IProvidersRepository ProvidersRepository;

        public ProvidersService(INotifier notifier,
            ILogger<ProvidersService> logger,
            IMapper mapper,
            IProvidersRepository providersRepository)
            : base(notifier, logger, mapper)
        {
            ProvidersRepository = providersRepository;
        }

        public async Task<ProvidersDto> Create(ProvidersDto provider)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProvidersDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProvidersDto> Edit(ProvidersDto provider)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ProvidersDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
