using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
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

        public async Task<OrdersDto> Create(OrdersDto order)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<OrdersDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<OrdersDto> Edit(OrdersDto order)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<OrdersDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
