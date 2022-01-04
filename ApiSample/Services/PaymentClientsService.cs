using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class PaymentClientsService : Service<PaymentClientsService>, IPaymentClientsService
    {
        private readonly IPaymentClientsRepository PaymentClientsRepository;

        public PaymentClientsService(INotifier notifier,
            ILogger<PaymentClientsService> logger,
            IMapper mapper,
            IPaymentClientsRepository paymentClientsRepository)
            : base(notifier, logger, mapper)
        {
            PaymentClientsRepository = paymentClientsRepository;
        }

        public async Task<PaymentClientsDto> Create(PaymentClientsDto paymentClient)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentClientsDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentClientsDto> Edit(PaymentClientsDto paymentClient)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<PaymentClientsDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
