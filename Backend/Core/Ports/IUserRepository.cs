using LoginEficaz.Core.Entities;

namespace LoginEficaz.Core.Ports
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
        Task<User> GetUserById(Guid userId);
        Task RegisterUser(User user);
        Task UpdateUser(User user);
    }
}
