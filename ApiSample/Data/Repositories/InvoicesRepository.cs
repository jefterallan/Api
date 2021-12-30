using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

namespace ApiSample.Data.Repositories
{
    public class InvoicesRepository : Repository<Invoices>, IInvoicesRepository
    {
        public InvoicesRepository(ApiSampleContext context) : base(context)
        {
        }
    }
}
