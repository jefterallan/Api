using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
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
