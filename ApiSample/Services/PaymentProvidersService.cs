using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class PaymentProvidersService : Service<PaymentProvidersService>, IPaymentProvidersService
    {
        private readonly IPaymentClientsRepository PaymentClientsRepository;

        public PaymentProvidersService(INotifier notifier,
            ILogger<PaymentProvidersService> logger,
            IPaymentClientsRepository paymentClientsRepository)
            : base(notifier, logger)
        {
            PaymentClientsRepository = paymentClientsRepository;
        }

        public Task<PaymentProviders> Create(PaymentProviders paymentProvider)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(PaymentProviders paymentProvider)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentProviders?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentProviders> Edit(PaymentProviders paymentProvider)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PaymentProviders>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
