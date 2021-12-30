using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class ProvidersRepository : Repository<Providers>, IProvidersRepository
    {
        public ProvidersRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
