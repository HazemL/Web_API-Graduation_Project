using BusinessLogic.DTOs.Professions;

namespace BusinessLogic.Interface
{
    // Contract خاص بـ Profession Service
    public interface IProfessionService
    {
        Task<IEnumerable<ProfessionResponseDto>> GetAllAsync();
        Task<ProfessionResponseDto?> GetByIdAsync(int id);

        Task CreateAsync(CreateProfessionDto dto);
        Task UpdateAsync(int id, UpdateProfessionDto dto);
        Task DeleteAsync(int id);
    }
}
