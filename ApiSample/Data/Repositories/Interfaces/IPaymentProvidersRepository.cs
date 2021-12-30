using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IPaymentProvidersRepository
    {
        ICollection<PaymentProviders> Get();
        IAsyncEnumerable<PaymentProviders> Create(PaymentProviders entity);
        IAsyncEnumerable<PaymentProviders> Edit(PaymentProviders entity);
        IAsyncEnumerable<PaymentProviders?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(PaymentProviders entity);
    }
}
