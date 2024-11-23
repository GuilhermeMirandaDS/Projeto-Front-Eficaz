using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace LoginEficaz.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IUserRepository _userRepository;

        public AddressService(IAddressRepository addressRepository, IUserRepository userRepository)
        {
            _addressRepository = addressRepository;
            _userRepository = userRepository;
        }

        public async Task<List<AddressDTO>> GetAddressByUser(Guid userId)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
                throw new KeyNotFoundException("User not found");

            var addresses = await _addressRepository.GetAddressesByUserId(userId);
            var addressDTOs = addresses.Select(a => new AddressDTO
            {
                Id = a.Id,
                Street = a.Street,
                Number = a.Number,
                Neighborhood = a.Neighborhood,
                City = a.City,
                ZipCode = a.ZipCode,
                UserId = a.UserId
            }).ToList();

            return addressDTOs;
        }

        public async Task RegisterAddress(AddressDTO addressDto)
        {
            var user = await _userRepository.GetUserById(addressDto.UserId);
            if (user == null)
                throw new KeyNotFoundException("User not found");

            var address = new Address
            {
                UserId = addressDto.UserId,
                Street = addressDto.Street,
                Number = addressDto.Number,
                Neighborhood = addressDto.Neighborhood,
                City = addressDto.City,
                ZipCode = addressDto.ZipCode
            };

            await _addressRepository.RegisterAddress(address);
        }

        public async Task<bool> UpdateAddress(AddressDTO addressDto)
        {
            var address = new Address
            {
                Id = addressDto.Id,
                UserId = addressDto.UserId,
                Street = addressDto.Street,
                Number = addressDto.Number,
                Neighborhood = addressDto.Neighborhood,
                City = addressDto.City,
                ZipCode = addressDto.ZipCode
            };

            return await _addressRepository.UpdateAddress(address);
        }

        public async Task<bool> DeleteAddress(int id)
        {
            return await _addressRepository.DeleteAddress(id);
        }
    }
}
