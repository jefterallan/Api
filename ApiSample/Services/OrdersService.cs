using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class OrdersService : Service<OrdersService>, IOrdersService
    {
        private readonly IOrdersRepository OrdersRepository;

        public OrdersService(INotifier notifier,
            ILogger<OrdersService> logger,
            IMapper mapper,
            IOrdersRepository ordersRepository)
            : base(notifier, logger, mapper)
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

        public Task<IList<Orders>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
