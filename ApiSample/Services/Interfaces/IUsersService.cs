using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface IUsersService : IService<UsersDto>
    {
        Task<UsersDto?> FindApiCredentials(CredentialDto credential);
    }
}
