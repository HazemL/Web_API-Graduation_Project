using AutoMapper;
using BusinessLogic.DTOs.Auth;
using BusinessLogic.Interface;
using BusinessLogic.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

public class AuthService : IAuthService
{
    private readonly Context _context;
    private readonly IMapper _mapper;
    private readonly IPasswordHasher _hasher;
    private readonly ITokenService _tokenService;

    public AuthService(
        Context context,
        IMapper mapper,
        IPasswordHasher hasher,
        ITokenService tokenService)
    {
        _context = context;
        _mapper = mapper;
        _hasher = hasher;
        _tokenService = tokenService;
    }

    public async Task<AuthResponseDto> RegisterAsync(RegisterRequestDto dto)
    {
        if (await _context.Users.AnyAsync(x => x.Email == dto.Email))
            throw new Exception("Email already exists");

        var user = _mapper.Map<User>(dto);
        user.PasswordHash = _hasher.Hash(dto.Password);

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return await _tokenService.GenerateAsync(user);
    }

    public async Task<AuthResponseDto> LoginAsync(LoginRequestDto dto)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(x => x.Email == dto.Email && !x.IsDeleted);

        if (user == null ||
            !_hasher.Verify(dto.Password, user.PasswordHash))
            throw new Exception("Invalid email or password");

        if (!user.IsActive)
            throw new Exception("User disabled");

        return await _tokenService.GenerateAsync(user);
    }

    public async Task<AuthResponseDto> RefreshTokenAsync(string refreshToken)
        => await _tokenService.RefreshAsync(refreshToken);

    public async Task LogoutAsync(int userId)
    {
        var tokens = await _context.RefreshTokens
            .Where(x => x.UserId == userId && !x.IsRevoked)
            .ToListAsync();

        tokens.ForEach(x => x.IsRevoked = true);
        await _context.SaveChangesAsync();
    }
}
