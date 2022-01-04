using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Helpers;
using ApiSample.Services.Dto;
using ApiSample.Services.Dto.Validations;
using ApiSample.Services.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace ApiSample.Services
{
    public class UsersService : Service<UsersService>, IUsersService
    {
        private readonly IUsersRepository UsersRepository;
        private readonly IMapper _mapper;
        private string Key { get; set; }

        public UsersService(INotifier notifier,
            ILogger<UsersService> logger,
            IMapper mapper,
            IOptions<AppSettingsMap> appSettings,
            IUsersRepository usersRepository)
            : base(notifier, logger, mapper)
        {
            UsersRepository = usersRepository;
            _mapper = mapper;
            Key = appSettings.Value?.CryptoKey ?? string.Empty;
        }

        public Task<UsersDto> Create(UsersDto user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(UsersDto user)
        {
            throw new NotImplementedException();
        }

        public Task<UsersDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UsersDto> Edit(UsersDto user)
        {
            throw new NotImplementedException();
        }

        public async Task<UsersDto?> FindApiCredentials(CredentialDto credential)
        {
            if (credential == null)
            {
                Notify("Credentials cannot be null");
                return null;
            }

            if (!ValidateModel(new CredentialValidation(), credential))
                return null;

            //password encrypt

            var result = await UsersRepository.FindApiCredentials(credential);

            return Mapper.Map<UsersDto>(result);
        }

        public Task<IList<UsersDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
