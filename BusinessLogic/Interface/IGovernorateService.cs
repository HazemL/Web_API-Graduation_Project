using BusinessLogic.DTOs.Governorates;

namespace BusinessLogic.Interfaces
{
    public interface IGovernorateService
    {
        Task<IEnumerable<GovernorateListDto>> GetAllAsync();
        Task<GovernorateDetailsDto?> GetByIdAsync(int id);
        Task AddAsync(AddGovernorateDto dto);
        Task UpdateAsync(int id, UpdateGovernorateDto dto);
        Task DeleteAsync(int id);
    }
}
