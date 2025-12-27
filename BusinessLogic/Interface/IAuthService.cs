using BusinessLogic.Common;
using BusinessLogic.DTOs.Auth;

public interface IAuthService
{
    Task<ServiceResult<AuthResponseDto>> RegisterAsync(RegisterRequestDto dto);
    Task<ServiceResult<AuthResponseDto>> LoginAsync(LoginRequestDto dto);
    Task<ServiceResult<AuthResponseDto>> RefreshTokenAsync(string refreshToken);
    Task<ServiceResult<bool>> LogoutAsync(int userId);
}
