using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class InvoicesService : Service, IInvoicesService
    {
        private readonly IInvoicesRepository InvoicesRepository;

        public InvoicesService(ILogger<InvoicesService> logger,
            IMapper mapper,
            INotifier notifier,
            IInvoicesRepository invoicesRepository)
            : base(logger, mapper, notifier)
        {
            InvoicesRepository = invoicesRepository;
        }

        public async Task<InvoicesDto> Create(InvoicesDto invoice)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<InvoicesDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<InvoicesDto> Edit(InvoicesDto invoice)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<InvoicesDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
