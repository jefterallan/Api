using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class ClientsService : Service<ClientsService>, IClientsService
    {
        private readonly IClientsRepository ClientRepository;

        public ClientsService(INotifier notifier,
            ILogger<ClientsService> logger,
            IClientsRepository clientRepository)
            : base(notifier, logger)
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

        public Task<ICollection<Clients>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
