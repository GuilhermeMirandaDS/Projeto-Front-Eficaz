using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IUserService
    {
        Task RegisterUser(RegisterUserDTO registerUser);
        Task<string> AuthenticateUser(LoginUserDTO loginUser);
        Task UpdateUserProfile(Guid userId, UpdateProfileDTO updateProfile);
    }
}
