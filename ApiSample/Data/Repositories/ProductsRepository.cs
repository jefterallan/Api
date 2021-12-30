using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class ProductsRepository : Repository<Products>, IProductsRepository
    {
        public ProductsRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
