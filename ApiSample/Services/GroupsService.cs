using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class GroupsService : Service<GroupsService>, IGroupsService
    {
        private readonly IGroupsRepository GroupsRepository;

        public GroupsService(INotifier notifier,
            ILogger<GroupsService> logger, IGroupsRepository groupsRepository)
            : base(notifier, logger)
        {
            GroupsRepository = groupsRepository;
        }

        public Task<Groups> Create(Groups group)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Groups group)
        {
            throw new NotImplementedException();
        }

        public Task<Groups?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Groups> Edit(Groups group)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Groups>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
