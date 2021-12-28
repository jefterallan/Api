using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class BrandService : Service, IBrandService
    {
        public BrandService(INotifier notifier) : base(notifier)
        {
        }
    }
}
