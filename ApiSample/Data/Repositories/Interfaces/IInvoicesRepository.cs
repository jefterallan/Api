using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IInvoicesRepository
    {
        ICollection<Invoices> Get();
        IAsyncEnumerable<Invoices> Create(Invoices entity);
        IAsyncEnumerable<Invoices> Edit(Invoices entity);
        IAsyncEnumerable<Invoices?> Details(Guid id);
        IAsyncEnumerable<bool> Delete(Guid id);
        IAsyncEnumerable<bool> Delete(Invoices entity);
    }
}
