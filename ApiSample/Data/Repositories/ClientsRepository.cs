using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class ClientsRepository : Repository<Clients>, IClientsRepository
    {
        public ClientsRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
