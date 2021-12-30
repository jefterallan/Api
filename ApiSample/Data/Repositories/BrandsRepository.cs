using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class BrandsRepository : Repository<Brands>, IBrandsRepository
    {
        public BrandsRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
