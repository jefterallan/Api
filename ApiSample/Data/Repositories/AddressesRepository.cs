using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class AddressesRepository : Repository<Addresses>, IAddressesRepository
    {
        public AddressesRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
