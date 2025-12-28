using BusinessLogic.DTOs.Craftsmen;

namespace BusinessLogic.Interface
{
    public interface ICraftsmanSearchService
    {
        Task<IEnumerable<CraftsmanSearchResultDto>> SearchAsync(
            string? name,
            int? professionId,
            int? governorateId,
            int? cityId,
            decimal? minPrice,
            decimal? maxPrice,
            int? minExperience,
            bool? isVerified
        );
    }
}
