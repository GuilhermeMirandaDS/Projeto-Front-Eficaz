using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;

namespace LoginEficaz.Core.Ports
{
    public interface IUserService
    {
        Task RegisterUser(RegisterUserDTO registerUser);
        Task<string> AuthenticateUser(LoginUserDTO loginUser);
        Task UpdateUserProfile(Guid userId, UpdateProfileDTO updateProfile);
        Task<string> UploadProfilePicture(Guid userId, FileData file);
        Task<User> GetUserById(Guid userId);
    }
}
