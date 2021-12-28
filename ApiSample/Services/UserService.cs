using ApiSample.Data.Models;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class UserService : Service, IUserService
    {
        public UserService(INotifier notifier) : base(notifier)
        {
        }

        public Task<User> FindApiCredentials(CredentialDto credentials)
        {
            throw new NotImplementedException();
        }
    }
}
