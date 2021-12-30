using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class PaymentClientsService : Service<PaymentClientsService>, IPaymentClientsService
    {
        private readonly IPaymentClientsRepository PaymentClientsRepository;

        public PaymentClientsService(INotifier notifier,
            ILogger<PaymentClientsService> logger,
            IPaymentClientsRepository paymentClientsRepository)
            : base(notifier, logger)
        {
            PaymentClientsRepository = paymentClientsRepository;
        }

        public Task<PaymentClients> Create(PaymentClients paymentClient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(PaymentClients paymentClient)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentClients?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentClients> Edit(PaymentClients paymentClient)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PaymentClients>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
