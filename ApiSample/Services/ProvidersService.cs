using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
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

        public Task<Providers> Create(Providers provider)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Providers provider)
        {
            throw new NotImplementedException();
        }

        public Task<Providers?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Providers> Edit(Providers provider)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Providers>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
