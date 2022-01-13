using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class ClientsService : Service, IClientsService
    {
        private readonly IClientsRepository ClientRepository;

        public ClientsService(ILogger<ClientsService> logger,
            IMapper mapper,
            INotifier notifier,
            IClientsRepository clientRepository)
            : base(logger, mapper, notifier)
        {
            ClientRepository = clientRepository;
        }

        public async Task<ClientsDto> Create(ClientsDto client)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ClientsDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ClientsDto> Edit(ClientsDto client)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ClientsDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
