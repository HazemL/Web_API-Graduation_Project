using BusinessLogic.DTOs.Auth;
using DataAccess.Models;

namespace BusinessLogic.Interfaces
{

    public interface ITokenService
    {
        Task<AuthResponseDto> GenerateAsync(User user);
        Task<AuthResponseDto> RefreshAsync(string refreshToken);
    }


}
