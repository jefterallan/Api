using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IPaymentClientsRepository
    {
        ICollection<PaymentClients> Get();
        IAsyncEnumerable<PaymentClients> Create(PaymentClients entity);
        IAsyncEnumerable<PaymentClients> Edit(PaymentClients entity);
        IAsyncEnumerable<PaymentClients?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(PaymentClients entity);
    }
}
