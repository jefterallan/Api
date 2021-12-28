using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class GroupService : Service, IGroupService
    {
        public GroupService(INotifier notifier) : base(notifier)
        {
        }
    }
}
