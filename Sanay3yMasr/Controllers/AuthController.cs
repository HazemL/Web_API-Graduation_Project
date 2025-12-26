using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequestDto dto)
        => Ok(await _authService.RegisterAsync(dto));

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequestDto dto)
        => Ok(await _authService.LoginAsync(dto));

    [HttpPost("refresh-token")]
    public async Task<IActionResult> Refresh(RefreshTokenRequestDto dto)
        => Ok(await _authService.RefreshTokenAsync(dto.RefreshToken));

    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        await _authService.LogoutAsync(userId);
        return Ok("Logged out");
    }
}
