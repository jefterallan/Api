using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class ProductPricesRepository : Repository<ProductPrices>, IProductPricesRepository
    {
        public ProductPricesRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
