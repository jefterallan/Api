using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class PaymentProvidersService : Service, IPaymentProvidersService
    {
        private readonly IPaymentClientsRepository PaymentClientsRepository;

        public PaymentProvidersService(ILogger<PaymentProvidersService> logger,
            IMapper mapper,
            INotifier notifier,
            IPaymentClientsRepository paymentClientsRepository)
            : base(logger, mapper, notifier)
        {
            PaymentClientsRepository = paymentClientsRepository;
        }

        public async Task<PaymentProvidersDto> Create(PaymentProvidersDto paymentProvider)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentProvidersDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentProvidersDto> Edit(PaymentProvidersDto paymentProvider)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<PaymentProvidersDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
