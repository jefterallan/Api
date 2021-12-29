using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> ClientRepository;

        public ClientService(IRepository<Client> clientRepository)
        {
            ClientRepository = clientRepository;
        }

        public void Test()
        {
            var t = new Client();

            ClientRepository.Create(t);
        }
    }
}
