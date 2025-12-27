using BusinessLogic.DTOs.Auth;
using DataAccess.Models;

namespace BusinessLogic.Interfaces
{
    
    public interface ITokenService
    {
        // Generate access + refresh tokens
        Task<AuthResponseDto> GenerateAsync(User user);

        // Refresh token (null if invalid / expired)
        Task<AuthResponseDto?> RefreshAsync(string refreshToken);
    }
}
