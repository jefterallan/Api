using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class ProductService : Service, IProductService
    {
        public ProductService(INotifier notifier) : base(notifier)
        {
        }
    }
}
