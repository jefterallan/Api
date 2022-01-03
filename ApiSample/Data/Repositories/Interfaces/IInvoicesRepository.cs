using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IInvoicesRepository
    {
        Task<IList<Invoices>> Get();
        Task<Invoices> Create(Invoices entity);
        Task<Invoices> Edit(Invoices entity);
        Task<Invoices?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Invoices entity);
    }
}
