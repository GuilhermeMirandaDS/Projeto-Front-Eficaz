using LoginEficaz.Adapters.Secondary.Infra.Data.Context;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginEficaz.Adapters.Secondary.Infra.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AddressRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RegisterAddress(Address address)
        {
            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Address> GetAddressById(int id)
        {
            return await _dbContext.Addresses.FindAsync(id);
        }

        public async Task<List<Address>> GetAddressesByUserId(Guid userId)
        {
            return await _dbContext.Addresses
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }

        public async Task<bool> UpdateAddress(Address updatedAddress)
        {
            var existingAddress = await _dbContext.Addresses.FindAsync(updatedAddress.Id);
            if (existingAddress == null)
            {
                return false;
            }

            _dbContext.Entry(existingAddress).CurrentValues.SetValues(updatedAddress);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAddress(int id)
        {
            var address = await _dbContext.Addresses.FindAsync(id);
            if (address == null)
            {
                return false;
            }

            _dbContext.Addresses.Remove(address);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
