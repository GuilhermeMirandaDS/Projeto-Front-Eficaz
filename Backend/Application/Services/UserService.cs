using LoginEficaz.Adapters.Secondary.Infra.Auth;
using LoginEficaz.Adapters.Secondary.Infra.Data.Repositories;
using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;

namespace LoginEficaz.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly TokenService _tokenService;
        private readonly IImageService _imageService;

        public UserService(IUserRepository userRepository, TokenService tokenService, IImageService imageService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _imageService = imageService;

        }

        public async Task RegisterUser(RegisterUserDTO registerUser)
        {
            if (registerUser.Password != registerUser.ConfirmPassword)
                throw new ArgumentException("Passwords do not match");

            var newUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName,
                Dob = registerUser.Dob,
                TelefoneFixo = registerUser.TelefoneFixo,
                Celular = registerUser.Celular,
                Gender = registerUser.Gender,
                CPF = registerUser.CPF,
                Username = registerUser.Username,
                Email = registerUser.Email,
                TermsAgreed = registerUser.TermsAgreed,
                PasswordHash = HashPassword(registerUser.Password)
            };

            await _userRepository.RegisterUser(newUser);
        }

        public async Task<string> AuthenticateUser(LoginUserDTO loginUser)
        {
            var user = await _userRepository.GetUserByUsername(loginUser.Username);

            if (user != null && VerifyPassword(loginUser.Password, user.PasswordHash))
            {
                return _tokenService.GenerateToken(user);
            }

            throw new UnauthorizedAccessException("Invalid username or password");
        }

        public async Task UpdateUserProfile(Guid userId, UpdateProfileDTO updateProfile)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
                throw new KeyNotFoundException("User not found");

            user.FirstName = updateProfile.FirstName;
            user.LastName = updateProfile.LastName;
            user.Dob = updateProfile.Dob;
            user.TelefoneFixo = updateProfile.TelefoneFixo;
            user.Celular = updateProfile.Celular;
            user.Gender = updateProfile.Gender;
            user.CPF = updateProfile.CPF;
            user.Email = updateProfile.Email;

            await _userRepository.UpdateUser(user);
        }
        public async Task<User> GetUserById(Guid userId)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
                throw new KeyNotFoundException("User not found");

            return user;
        }

        public async Task<string> UploadProfilePicture(Guid userId, FileData file)
        {
            User user = await GetUserById(userId);

            string uploadedFileUrl = await _imageService.UploadImage(file, "users", $"{user.Username}");

            user.ImageUrl = uploadedFileUrl;

            await _userRepository.UploadImage();

            return uploadedFileUrl;
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}
