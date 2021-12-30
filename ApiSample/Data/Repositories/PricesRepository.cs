using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class PricesRepository : Repository<Prices>, IPricesRepository
    {
        public PricesRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
