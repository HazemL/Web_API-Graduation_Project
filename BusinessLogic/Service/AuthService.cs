using AutoMapper;
using BusinessLogic.Common;
using BusinessLogic.DTOs.Auth;
using BusinessLogic.Interface;
using BusinessLogic.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
   
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

        // =========================
        // REGISTER
        // =========================
        public async Task<ServiceResult<AuthResponseDto>> RegisterAsync(RegisterRequestDto dto)
        {
            // Check email existence
            bool emailExists = await _context.Users
                .AnyAsync(x => x.Email == dto.Email && !x.IsDeleted);

            if (emailExists)
                return ServiceResult<AuthResponseDto>
                    .Fail("Email already exists");

            // Map DTO -> User
            var user = _mapper.Map<User>(dto);

            // Hash password
            user.PasswordHash = _hasher.Hash(dto.Password);
            user.IsActive = true;

            // Save user
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Generate tokens
            var authResponse = await _tokenService.GenerateAsync(user);

            return ServiceResult<AuthResponseDto>
                .Ok(authResponse, "Registered successfully");
        }

        // =========================
        // LOGIN
        // =========================
        public async Task<ServiceResult<AuthResponseDto>> LoginAsync(LoginRequestDto dto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x =>
                    x.Email == dto.Email &&
                    !x.IsDeleted);

            if (user == null)
                return ServiceResult<AuthResponseDto>
                    .Fail("Invalid email or password");

            if (!_hasher.Verify(dto.Password, user.PasswordHash))
                return ServiceResult<AuthResponseDto>
                    .Fail("Invalid email or password");

            if (!user.IsActive)
                return ServiceResult<AuthResponseDto>
                    .Fail("User is disabled");

            var authResponse = await _tokenService.GenerateAsync(user);

            return ServiceResult<AuthResponseDto>
                .Ok(authResponse, "Login successful");
        }

        // =========================
        // REFRESH TOKEN
        // =========================
        public async Task<ServiceResult<AuthResponseDto>> RefreshTokenAsync(string refreshToken)
        {
            var authResponse = await _tokenService.RefreshAsync(refreshToken);

            if (authResponse == null)
                return ServiceResult<AuthResponseDto>
                    .Fail("Invalid or expired refresh token");

            return ServiceResult<AuthResponseDto>
                .Ok(authResponse, "Token refreshed successfully");
        }

        // =========================
        // LOGOUT
        // =========================
        public async Task<ServiceResult<bool>> LogoutAsync(int userId)
        {
            var tokens = await _context.RefreshTokens
                .Where(x => x.UserId == userId && !x.IsRevoked)
                .ToListAsync();

            if (!tokens.Any())
                return ServiceResult<bool>
                    .Fail("No active sessions found");

            tokens.ForEach(x => x.IsRevoked = true);
            await _context.SaveChangesAsync();

            return ServiceResult<bool>
                .Ok(true, "Logged out successfully");
        }
    }
}
