using BusinessLogic.DTOs.Craftsmen;

namespace BusinessLogic.Interface
{
    public interface ICraftsmanService
    {
        Task<IEnumerable<GetCraftsmanDto>> GetAllAsync();
        Task<GetCraftsmanDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateCraftsmanDto dto);
        Task<bool> UpdateAsync(int id, UpdateCraftsmanDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
