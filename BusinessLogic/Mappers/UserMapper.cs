using BusinessLogic.DTOs.Auth;
using BusinessLogic.Security;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
 
    public static class UserMapper
    {
        public static User FromRegisterDto(RegisterRequestDto dto, string role)
        {
            return new User
            {
                // Normalize Email
                Email = dto.Email.Trim().ToLower(),

                FullName = dto.FullName.Trim(),

                // Phone اختياري
                Phone = string.IsNullOrWhiteSpace(dto.Phone)
                        ? null
                        : dto.Phone.Trim(),

                Role = role,

                // Hash 
                PasswordHash = PasswordHasher.Hash(dto.Password),

                // Default Profile Image
                ProfileImage = "default.png",

                IsActive = true,
                IsDeleted = false,

                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
    }
}
