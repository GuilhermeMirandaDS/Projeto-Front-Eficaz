using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IAddressService
    {
        Task<List<AddressDTO>> GetAddressByUser(Guid userId);
        Task RegisterAddress(AddressDTO address);
        Task<bool> UpdateAddress(AddressDTO address);
        Task<bool> DeleteAddress(int id);
    }
}