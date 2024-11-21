using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IAddressService
    {
        IEnumerable<AddressDTO> GetAll();
        AddressDTO GetById(int id);
        void Create(AddressDTO address);
        bool Update(AddressDTO address);
        bool Delete(int id);
    }
}
