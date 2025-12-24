using BusinessLogic.DTOs.City;

namespace BusinessLogic.Interface
{
    // Interface بين Controller و Service
    public interface ICityService
    {
        Task<IEnumerable<GetAllCityDto>> GetAllAsync();
        Task<GetCityByIdDto?> GetByIdAsync(int id);
        Task<IEnumerable<GetAllCityDto>> GetByGovernorateAsync(int governorateId);

        Task AddAsync(AddCityDto dto);
        Task UpdateAsync(int id, UpdateCityDto dto);
        Task DeleteAsync(int id);
    }
}
