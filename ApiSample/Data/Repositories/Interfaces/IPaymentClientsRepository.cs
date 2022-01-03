using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IPaymentClientsRepository
    {
        Task<IList<PaymentClients>> Get();
        Task<PaymentClients> Create(PaymentClients entity);
        Task<PaymentClients> Edit(PaymentClients entity);
        Task<PaymentClients?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(PaymentClients entity);
    }
}
