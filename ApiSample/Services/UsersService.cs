using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class UsersService : Service<UsersService>, IUsersService
    {
        private readonly IUsersRepository UsersRepository;

        public UsersService(INotifier notifier,
            ILogger<UsersService> logger,
            IMapper mapper,
            IUsersRepository usersRepository)
            : base(notifier, logger, mapper)
        {
            UsersRepository = usersRepository;
        }

        public Task<Users> Create(Users user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Users user)
        {
            throw new NotImplementedException();
        }

        public Task<Users?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> Edit(Users user)
        {
            throw new NotImplementedException();
        }

        public Task<Users> FindApiCredentials(CredentialDto credential)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Users>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
