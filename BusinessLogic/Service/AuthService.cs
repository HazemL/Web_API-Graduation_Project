using BusinessLogic.Constants;
using BusinessLogic.DTOs.Auth;
using BusinessLogic.Interface;
using BusinessLogic.Mappers;
using BusinessLogic.Security;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BusinessLogic.Service
{
    public class AuthService : IAuthService
    {
        private readonly Context _context;
        private readonly JwtTokenGenerator _jwt;

        public AuthService(Context context, JwtTokenGenerator jwt)
        {
            _context = context;
            _jwt = jwt;
        }

        // ===================== REGISTER =====================
        public async Task<AuthResponseDto> RegisterAsync(RegisterRequestDto dto)
        {
            // Normalize Email (علشان case insensitive)
            var email = dto.Email.Trim().ToLower();

            // Password validation
            if (string.IsNullOrWhiteSpace(dto.Password) || dto.Password.Length < 6)
                throw new Exception("Password must be at least 6 characters");

            // Check if email already exists
            var exists = await _context.Users
                .AnyAsync(x => x.Email == email && !x.IsDeleted);

            if (exists)
                throw new Exception("Email already exists");

            // Prevent self-register as Admin
            var role = string.IsNullOrWhiteSpace(dto.Role)
                ? Roles.Customer
                : dto.Role.Trim();

            // Normalize role format (Admin / Customer / Craftsman)
            role = char.ToUpper(role[0]) + role[1..].ToLower();

            // Validate role
            if (!Roles.AllowedRegisterRoles.Contains(role))
                throw new Exception("Invalid role");

            // Map DTO → Entity
            var user = UserMapper.FromRegisterDto(dto, role);

            // Save user
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Generate JWT
            return _jwt.Generate(user);
        }

        // ===================== LOGIN =====================
        public async Task<AuthResponseDto> LoginAsync(LoginRequestDto dto)
        {
            var email = dto.Email.Trim().ToLower();

            // Get user
            var user = await _context.Users
                .FirstOrDefaultAsync(x =>
                    x.Email == email &&
                    !x.IsDeleted);

            if (user == null)
                throw new Exception("Invalid email or password");

            // Verify password hash
            if (!PasswordHasher.Verify(user.PasswordHash, dto.Password))
                throw new Exception("Invalid email or password");

            // Check active flag
            if (!user.IsActive)
                throw new Exception("User is disabled");

            // Generate JWT
            return _jwt.Generate(user);
        }

        // ===================== LOGOUT =====================
        public async Task LogoutAsync(ClaimsPrincipal user)
        {
            // Extract JTI from JWT
            var jti = user.FindFirst(JwtRegisteredClaimNames.Jti)?.Value;

            if (string.IsNullOrEmpty(jti))
                throw new Exception("Invalid token");

            //  لو التوكن متلغى قبل كده
            var exists = await _context.RevokedTokens
                .AnyAsync(x => x.Jti == jti);

            if (exists)
                return;

            // نلغيه
            _context.RevokedTokens.Add(new RevokedToken
            {
                Jti = jti,
                RevokedAt = DateTime.UtcNow
            });

            await _context.SaveChangesAsync();
        }
    }
}
