using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class PaymentClientsRepository : Repository<PaymentClients>, IPaymentClientsRepository
    {
        public PaymentClientsRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
