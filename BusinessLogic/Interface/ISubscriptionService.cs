using BusinessLogic.DTOs.Subscriptions;

namespace BusinessLogic.Interface
{
    public interface ISubscriptionService
    {
        // GET /api/craftsmen/{craftsmanId}/subscriptions
        Task<IEnumerable<SubscriptionResponseDto>> GetByCraftsmanAsync(int craftsmanId);

        // POST /api/craftsmen/{craftsmanId}/subscriptions
        Task<SubscriptionResponseDto> CreateAsync(int craftsmanId,CreateSubscriptionDto dto);

        // PUT /api/subscriptions/{id}/cancel
        Task<bool> CancelAsync(int id);
    }
}
