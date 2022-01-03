using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class InvoicesService : Service<InvoicesService>, IInvoicesService
    {
        private readonly IInvoicesRepository InvoicesRepository;

        public InvoicesService(INotifier notifier,
            ILogger<InvoicesService> logger,
            IMapper mapper,
            IInvoicesRepository invoicesRepository)
            : base(notifier, logger, mapper)
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

        public Task<IList<Invoices>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
