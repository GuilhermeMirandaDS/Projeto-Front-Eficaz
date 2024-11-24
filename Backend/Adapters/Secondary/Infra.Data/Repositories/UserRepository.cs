using LoginEficaz.Adapters.Secondary.Infra.Data.Context;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using Microsoft.EntityFrameworkCore;

namespace LoginEficaz.Adapters.Secondary.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User> GetUserById(Guid userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task RegisterUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task UploadImage()
        {
            await _context.SaveChangesAsync();
        }
    }
}
