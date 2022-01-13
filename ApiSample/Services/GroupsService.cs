using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class GroupsService : Service, IGroupsService
    {
        private readonly IGroupsRepository GroupsRepository;

        public GroupsService(ILogger<GroupsService> logger,
            IMapper mapper,
            INotifier notifier,
            IGroupsRepository groupsRepository)
            : base(logger, mapper, notifier)
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
