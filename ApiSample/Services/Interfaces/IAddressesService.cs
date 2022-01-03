using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface IAddressesService
    {
        Task<IList<AddressesDto>> Get();
        Task<AddressesDto> Create(AddressesDto address);
        Task<AddressesDto> Edit(AddressesDto address);
        Task<AddressesDto?> Details(Guid id);
        Task<bool> Delete(Guid id);
        Task<bool> Delete(AddressesDto address);
    }
}
