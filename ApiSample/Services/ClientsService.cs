using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class ClientsService : Service<ClientsService>, IClientsService
    {
        private readonly IClientsRepository ClientRepository;

        public ClientsService(INotifier notifier,
            ILogger<ClientsService> logger,
            IMapper mapper,
            IClientsRepository clientRepository)
            : base(notifier, logger, mapper)
        {
            ClientRepository = clientRepository;
        }

        public Task<Clients> Create(Clients client)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Clients client)
        {
            throw new NotImplementedException();
        }

        public Task<Clients?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Clients> Edit(Clients client)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Clients>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
