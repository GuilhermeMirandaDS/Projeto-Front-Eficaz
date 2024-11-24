using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginEficaz.Adapters.Primary.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registerUser)
        {
            await _userService.RegisterUser(registerUser);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUser)
        {
            var token = await _userService.AuthenticateUser(loginUser);
            return Ok(new { Token = token });
        }

        [HttpPut("profile")]
        [Authorize]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileDTO updateProfile)
        {
            var userId = User.FindFirst("id")?.Value;
            await _userService.UpdateUserProfile(Guid.Parse(userId), updateProfile);
            return Ok("Profile updated successfully");
        }
        [HttpGet("profile")]
        [Authorize]
        public async Task<IActionResult> GetUser()
        {
            var userId = User.FindFirst("id")?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized("User not authenticated");

            var user = await _userService.GetUserById(Guid.Parse(userId));
            return Ok(user);
        }
        [HttpPost("{userId}/UploadImage")]
        [Authorize]
        public async Task<ActionResult<string>> UploadProfilePicture(string userId, IFormFile file)
        {
            if (!Guid.TryParse(userId, out Guid parsedUserId))
            {
                return BadRequest("Invalid UserId format.");
            }

            if (file == null || file.Length == 0)
            {
                return BadRequest("No image found");
            }

            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            var fileData = new FileData
            {
                FileName = file.FileName,
                Content = memoryStream.ToArray(),
                ContentType = file.ContentType,
                Extension = Path.GetExtension(file.FileName),
            };

            string imageUrl = await _userService.UploadProfilePicture(parsedUserId, fileData);

            return CreatedAtAction(nameof(UploadProfilePicture), new { userId = parsedUserId }, imageUrl);
        }

    }
}
