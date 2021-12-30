using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class PaymentProvidersRepository : Repository<PaymentProviders>, IPaymentProvidersRepository
    {
        public PaymentProvidersRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
