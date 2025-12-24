using BusinessLogic.DTOs.Reports;

namespace BusinessLogic.Interface
{
    public interface IReportService
    {
        Task<IEnumerable<GetAllReportDto>> GetAllAsync();
        Task<GetReportByIdDto?> GetByIdAsync(int id);

        Task AddAsync(int reporterUserId, AddReportDto dto);
        Task ResolveAsync(int id);
    }
}
