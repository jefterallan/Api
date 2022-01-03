using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class GroupsService : Service<GroupsService>, IGroupsService
    {
        private readonly IGroupsRepository GroupsRepository;

        public GroupsService(INotifier notifier,
            ILogger<GroupsService> logger,
            IMapper mapper,
            IGroupsRepository groupsRepository)
            : base(notifier, logger, mapper)
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

        public Task<IList<Groups>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
