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

        // GET ALL USERS
        public async Task<IEnumerable<GetUserDto>> GetAllAsync()
        {
            var users = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GetUserDto>>(users);
        }

        // GET USER BY ID
        public async Task<GetUserDto?> GetByIdAsync(int id)
        {
            var user = await _repo.GetByID(id);
            if (user == null) return null;

            return _mapper.Map<GetUserDto>(user);
        }

        // UPDATE USER (ADMIN)
        public async Task<bool> UpdateAsync(int id, UpdateUserDto dto, string adminId)
        {
            var user = await _repo.GetByIDWithTracking(id);
            if (user == null) return false;

            _mapper.Map(dto, user);

            user.UpdatedBy = adminId;
            user.UpdatedAt = DateTime.Now;

            await _repo.Update(user);
            return true;
        }

        // DELETE USER (SOFT DELETE)
        public async Task<bool> DeleteAsync(int id, string adminId)
        {
            var user = await _repo.GetByIDWithTracking(id);
            if (user == null) return false;

            user.IsDeleted = true;
            user.IsActive = false;
            user.UpdatedBy = adminId;
            user.UpdatedAt = DateTime.Now;

            await _repo.Update(user);
            return true;
        }
    }
}
