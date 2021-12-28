using ApiSample.Data.Models;
using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> FindApiCredentials(CredentialDto credentials);
    }
}
