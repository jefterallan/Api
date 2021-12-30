using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class UsersService : Service<UsersService>, IUsersService
    {
        private readonly IUsersRepository UsersRepository;

        public UsersService(INotifier notifier,
            ILogger<UsersService> logger,
            IUsersRepository usersRepository)
            : base(notifier, logger)
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

        public Task<ICollection<Users>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
