using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IPaymentClientsService
    {
        Task<ICollection<PaymentClients>> Get();
        Task<PaymentClients> Create(PaymentClients paymentClient);
        Task<PaymentClients> Edit(PaymentClients paymentClient);
        Task<PaymentClients?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(PaymentClients paymentClient);
    }
}
