

namespace BusinessLogic.Interface
{
    public interface ICraftsmanSkillService
    {
        Task<IEnumerable<CraftsmanSkillResponseDto>> GetByCraftsmanAsync(int craftsmanId);
        Task AddAsync(int craftsmanId, CreateCraftsmanSkillDto dto);
        Task UpdateAsync(int craftsmanId, int skillId, UpdateCraftsmanSkillDto dto);
        Task DeleteAsync(int craftsmanId, int skillId);
    }
}
