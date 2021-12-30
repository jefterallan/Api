using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class InvoicesService : Service<InvoicesService>, IInvoicesService
    {
        private readonly IInvoicesRepository InvoicesRepository;

        public InvoicesService(INotifier notifier,
            ILogger<InvoicesService> logger,
            IInvoicesRepository invoicesRepository) : base(notifier, logger)
        {
            InvoicesRepository = invoicesRepository;
        }

        public Task<Invoices> Create(Invoices invoice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Invoices invoice)
        {
            throw new NotImplementedException();
        }

        public Task<Invoices?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Invoices> Edit(Invoices invoice)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Invoices>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
