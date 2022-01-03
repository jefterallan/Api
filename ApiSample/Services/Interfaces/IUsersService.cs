using ApiSample.Data.Models;
using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface IUsersService
    {
        Task<UsersDto?> FindApiCredentials(CredentialDto credential);
        Task<IList<UsersDto>> Get();
        Task<UsersDto> Create(UsersDto user);
        Task<UsersDto> Edit(UsersDto user);
        Task<UsersDto?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(UsersDto user);
    }
}
