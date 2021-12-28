using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class PriceService : Service, IPriceService
    {
        public PriceService(INotifier notifier) : base(notifier)
        {
        }
    }
}
