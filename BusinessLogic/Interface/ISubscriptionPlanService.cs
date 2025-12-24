using BusinessLogic.DTOs.SubscriptionPlans;

namespace BusinessLogic.Interface
{
    public interface ISubscriptionPlanService
    {
        Task<IEnumerable<GetSubscriptionPlanDto>> GetAllAsync();
        Task<GetSubscriptionPlanDto?> GetByIdAsync(int id);

        Task<int> CreateAsync(CreateSubscriptionPlanDto dto, string createdBy);
        Task<bool> UpdateAsync(int id, UpdateSubscriptionPlanDto dto, string updatedBy);
        Task<bool> DeleteAsync(int id, string deletedBy);
    }
}
