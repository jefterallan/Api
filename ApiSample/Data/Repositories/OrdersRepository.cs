using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class OrdersRepository : Repository<Orders>, IOrdersRepository
    {
        public OrdersRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
