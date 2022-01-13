using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class ProvidersService : Service, IProvidersService
    {
        private readonly IProvidersRepository ProvidersRepository;

        public ProvidersService(ILogger<ProvidersService> logger,
            IMapper mapper,
            INotifier notifier,
            IProvidersRepository providersRepository)
            : base(logger, mapper, notifier)
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
