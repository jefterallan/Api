using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
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

        public async Task<GroupsDto> Create(GroupsDto group)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<GroupsDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<GroupsDto> Edit(GroupsDto group)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<GroupsDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
