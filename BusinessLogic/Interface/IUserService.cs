using BusinessLogic.DTOs.Users;

namespace BusinessLogic.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<GetUserDto>> GetAllAsync();
        Task<GetUserDto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(int id, UpdateUserDto dto, string adminId);
        Task<bool> DeleteAsync(int id, string adminId);
    }
}
