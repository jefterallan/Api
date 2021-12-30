using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IPaymentProvidersService
    {
        Task<ICollection<PaymentProviders>> Get();
        Task<PaymentProviders> Create(PaymentProviders paymentProvider);
        Task<PaymentProviders> Edit(PaymentProviders paymentProvider);
        Task<PaymentProviders?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(PaymentProviders paymentProvider);
    }
}
