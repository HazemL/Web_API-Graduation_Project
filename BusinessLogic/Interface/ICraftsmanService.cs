using BusinessLogic.Common;
using BusinessLogic.DTOs.Craftsmen;

public interface ICraftsmanService
{
    Task<ServiceResult<IEnumerable<GetCraftsmanDto>>> GetAllAsync();
    Task<ServiceResult<GetCraftsmanDto>> GetByIdAsync(int id);
    Task<ServiceResult<int>> CreateAsync(CreateCraftsmanDto dto);
    Task<ServiceResult<bool>> UpdateAsync(int id, UpdateCraftsmanDto dto);
    Task<ServiceResult<bool>> DeleteAsync(int id);
}
