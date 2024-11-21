using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;

namespace LoginEficaz.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly List<Address> _addresses = new();

        public IEnumerable<AddressDTO> GetAll()
        {
            return _addresses.Select(a => new AddressDTO
            {
                Street = a.Street,
                Number = a.Number,
                Neighborhood = a.Neighborhood,
                City = a.City,
                ZipCode = a.ZipCode
            });
        }

        public AddressDTO GetById(int id)
        {
            var address = _addresses.FirstOrDefault(a => a.Id == id);
            return address == null ? null : new AddressDTO
            {
                Street = address.Street,
                Number = address.Number,
                Neighborhood = address.Neighborhood,
                City = address.City,
                ZipCode = address.ZipCode
            };
        }

        public void Create(AddressDTO address)
        {
            _addresses.Add(new Address
            {
                Id = _addresses.Count + 1,
                Street = address.Street,
                Number = address.Number,
                Neighborhood = address.Neighborhood,
                City = address.City,
                ZipCode = address.ZipCode
            });
        }

        public bool Update(AddressDTO address)
        {
            var existing = _addresses.FirstOrDefault(a => a.Id == address.Id);
            if (existing == null) return false;

            existing.Street = address.Street;
            existing.Number = address.Number;
            existing.Neighborhood = address.Neighborhood;
            existing.City = address.City;
            existing.ZipCode = address.ZipCode;
            return true;
        }

        public bool Delete(int id)
        {
            var address = _addresses.FirstOrDefault(a => a.Id == id);
            if (address == null) return false;

            _addresses.Remove(address);
            return true;
        }
    }
}
