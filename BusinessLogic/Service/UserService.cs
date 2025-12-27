using AutoMapper;
using BusinessLogic.DTOs.Users;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class UserService : IUserService
    {
        private readonly IGeneralRepository<User> _repo;
        private readonly IMapper _mapper;

        public UserService(
            IGeneralRepository<User> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetUserDto>> GetAllAsync()
        {
            var users = await _repo.GetAll()
                .Where(x => !x.IsDeleted)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetUserDto>>(users);
        }

        public async Task<GetUserDto?> GetByIdAsync(int id)
        {
            var user = await _repo.GetByID(id);
            if (user == null || user.IsDeleted)
                return null;

            return _mapper.Map<GetUserDto>(user);
        }

        public async Task<bool> UpdateAsync(int id, UpdateUserDto dto, string adminId)
        {
            var user = await _repo.GetByIDWithTracking(id);
            if (user == null || user.IsDeleted)
                return false;

            _mapper.Map(dto, user);
            user.UpdatedBy = adminId;
            user.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(user);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, string adminId)
        {
            var user = await _repo.GetByIDWithTracking(id);
            if (user == null || user.IsDeleted)
                return false;

            user.IsDeleted = true;
            user.IsActive = false;
            user.UpdatedBy = adminId;
            user.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(user);
            return true;
        }

        public async Task<bool> UpdateProfileImageAsync(int userId, string imageUrl)
        {
            var user = await _repo.GetByIDWithTracking(userId);
            if (user == null || user.IsDeleted)
                return false;

            user.ProfileImage = imageUrl;
            user.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(user);
            return true;
        }
    }
}
