using LoginEficaz.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace LoginEficaz.Core.Ports
{
    public interface IAddressRepository
    {
        Task RegisterAddress(Address address);
        Task<Address> GetAddressById(int id);
        Task<List<Address>> GetAddressesByUserId(Guid userId);
        Task<bool> UpdateAddress(Address updatedAddress);
        Task<bool> DeleteAddress(int id);
    }
}
