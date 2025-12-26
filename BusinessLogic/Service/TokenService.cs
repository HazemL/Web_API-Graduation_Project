using BusinessLogic.DTOs.Auth;
using BusinessLogic.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BusinessLogic.Services
{
    public class TokenService : ITokenService
    {
        private readonly Context _context;
        private readonly IConfiguration _config;

        public TokenService(Context context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        /// <summary>
        /// Generate Access Token (JWT) + Refresh Token
        /// </summary>
        public async Task<AuthResponseDto> GenerateAsync(User user)
        {
            // ============================
            // 🔐 JWT Claims
            // ============================
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

            // ============================
            // 🔑 JWT Key
            // ============================
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"]!)
            );

            // ============================
            // 🧾 Create JWT Token
            // ============================
            var jwtToken = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: new SigningCredentials(
                    key,
                    SecurityAlgorithms.HmacSha256
                )
            );

            // ============================
            // 🔄 Create Refresh Token
            // ============================
            var refreshToken = new RefreshToken
            {
                Token = Guid.NewGuid().ToString(),
                ExpiresAt = DateTime.UtcNow.AddDays(7),
                UserId = user.Id
            };

            _context.RefreshTokens.Add(refreshToken);
            await _context.SaveChangesAsync();

            // ============================
            // 📦 Response
            // ============================
            return new AuthResponseDto
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                AccessTokenExpiresAt = jwtToken.ValidTo,
                RefreshToken = refreshToken.Token,
                Role = user.Role,
                FullName = user.FullName
            };
        }

        /// <summary>
        /// Refresh access token using refresh token
        /// ❌ بدون Exceptions
        /// </summary>
        public async Task<AuthResponseDto?> RefreshAsync(string refreshToken)
        {
            var token = await _context.RefreshTokens
                .Include(x => x.User)
                .FirstOrDefaultAsync(x =>
                    x.Token == refreshToken &&
                    !x.IsRevoked &&
                    x.ExpiresAt > DateTime.UtcNow);

            // ❌ لا Exceptions
            if (token == null)
                return null;

            // Revoke old refresh token
            token.IsRevoked = true;
            await _context.SaveChangesAsync();

            // Generate new tokens
            return await GenerateAsync(token.User);
        }
    }
}
