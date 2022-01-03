using ApiSample.Data.Models;
using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface IUsersService
    {
        Task<Users> FindApiCredentials(CredentialDto credential);
        Task<IList<Users>> Get();
        Task<Users> Create(Users user);
        Task<Users> Edit(Users user);
        Task<Users?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Users user);
    }
}
