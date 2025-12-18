using BusinessLogic.Constants;
using BusinessLogic.DTOs.Auth;
using BusinessLogic.Interface;
using BusinessLogic.Mappers;
using BusinessLogic.Security;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

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
            //  Normalize Email
            var email = dto.Email.Trim().ToLower();

            // Password Validation
            if (string.IsNullOrWhiteSpace(dto.Password) || dto.Password.Length < 6)
                throw new Exception("Password must be at least 6 characters");

            //  Check Email Exists -- NO duplicate USER
            var exists = await _context.Users
                .AnyAsync(x => x.Email == email && !x.IsDeleted);

            if (exists)
                throw new Exception("Email already exists");

            //                    (Admin) حماية من إن حد يسجل نفسه  
            var role = string.IsNullOrWhiteSpace(dto.Role)
                ? Roles.Customer
                : dto.Role.Trim();

            // Normalize role case
            role = char.ToUpper(role[0]) + role[1..].ToLower();
            // علشان لو حد دخل قيمه غير ال قيم الموجوده 
            if (!Roles.AllowedRegisterRoles.Contains(role))
                throw new Exception("Invalid role");

            //  Map DTO → User Entity
            var user = UserMapper.FromRegisterDto(dto, role);

            //  Save
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            //  Generate JWT
            return _jwt.Generate(user);
        }

        // ===================== LOGIN =====================
        public async Task<AuthResponseDto> LoginAsync(LoginRequestDto dto)
        {
            var email = dto.Email.Trim().ToLower();

            //  Get User
            var user = await _context.Users
                .FirstOrDefaultAsync(x =>
                    x.Email == email &&
                    !x.IsDeleted);

            if (user == null)
                throw new Exception("Invalid email or password");

            //  Verify Password
            if (!PasswordHasher.Verify(user.PasswordHash, dto.Password))
                throw new Exception("Invalid email or password");

            //  Check Active
            if (!user.IsActive)
                throw new Exception("User is disabled");

            //  Generate JWT
            return _jwt.Generate(user);
        }
    }
}
