using BusinessLogic.DTOs.Review;
using BusinessLogic.DTOs.Reviews;

namespace BusinessLogic.Interface
{
    public interface IReviewService
    {
        Task<IEnumerable<GetReviewDto>> GetByCraftsmanAsync(int craftsmanId);

        Task<IEnumerable<GetReviewDto>> GetAllAsync(); // ✅ NEW

        Task AddAsync(int craftsmanId, int userId, AddReviewDto dto);

        Task VerifyAsync(int reviewId);

        Task DeleteAsync(int reviewId);

        Task<double> GetAverageAsync(int craftsmanId);
    }
}
