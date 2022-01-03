using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IPaymentProvidersRepository
    {
        Task<IList<PaymentProviders>> Get();
        Task<PaymentProviders> Create(PaymentProviders entity);
        Task<PaymentProviders> Edit(PaymentProviders entity);
        Task<PaymentProviders?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(PaymentProviders entity);
    }
}
