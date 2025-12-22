using BusinessLogic.DTOs.Craftsmen;

public interface ICraftsmanCityService
{
    Task<IEnumerable<CraftsmanCityResponseDto>> GetByCraftsmanAsync(int craftsmanId);
    Task AddAsync(int craftsmanId, CreateCraftsmanCityDto dto);
    Task SetPrimaryAsync(int craftsmanId, int cityId);
    Task DeleteAsync(int craftsmanId, int cityId);
}
