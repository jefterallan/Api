using ApiSample.Data.Models;

namespace ApiSample.Services.Interfaces
{
    public interface IInvoicesService
    {
        Task<IList<Invoices>> Get();
        Task<Invoices> Create(Invoices invoice);
        Task<Invoices> Edit(Invoices invoice);
        Task<Invoices?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Invoices invoice);
    }
}
