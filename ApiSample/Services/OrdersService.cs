using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class OrdersService : Service<OrdersService>, IOrdersService
    {
        private readonly IOrdersRepository OrdersRepository;

        public OrdersService(INotifier notifier,
            ILogger<OrdersService> logger,
            IOrdersRepository ordersRepository)
            : base(notifier, logger)
        {
            OrdersRepository = ordersRepository;
        }

        public Task<Orders> Create(Orders order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Orders order)
        {
            throw new NotImplementedException();
        }

        public Task<Orders?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> Edit(Orders order)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Orders>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
