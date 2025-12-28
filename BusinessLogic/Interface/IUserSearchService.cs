using BusinessLogic.DTOs.Users;

namespace BusinessLogic.Interface
{
    public interface IUserSearchService
    {
        Task<IEnumerable<UserSearchResultDto>> SearchAsync(
            string? name,
            string? email,
            string? phone,
            string? role,
            int? governorateId,
            int? cityId);
    }
}
