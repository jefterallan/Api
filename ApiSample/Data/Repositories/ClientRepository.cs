using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class ClientRepository : Repository<Client>
    {
        public ClientRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
