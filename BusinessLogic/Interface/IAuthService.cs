using BusinessLogic.DTOs.Auth;
using System.Security.Claims;

namespace BusinessLogic.Interface
{
    public interface IAuthService
    {
        // Register new user
        Task<AuthResponseDto> RegisterAsync(RegisterRequestDto dto);

        // Login existing user
        Task<AuthResponseDto> LoginAsync(LoginRequestDto dto);

        // Logout (invalidate current JWT)
        Task LogoutAsync(ClaimsPrincipal user);
    }
}
