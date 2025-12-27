using BusinessLogic.DTOs.Users;

namespace BusinessLogic.Interface
{
    public interface IUserService
    {
        // READ
        Task<IEnumerable<GetUserDto>> GetAllAsync();
        Task<GetUserDto?> GetByIdAsync(int id);

        // UPDATE (Admin)
        Task<bool> UpdateAsync(int id, UpdateUserDto dto, string adminId);

        // DELETE (Soft Delete)
        Task<bool> DeleteAsync(int id, string adminId);

        // UPDATE PROFILE IMAGE (Logged-in User)
        Task<bool> UpdateProfileImageAsync(int userId, string imageUrl);
    }
}
