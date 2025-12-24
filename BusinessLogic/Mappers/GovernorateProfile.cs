using AutoMapper;
using BusinessLogic.DTOs.Governorates;
using DataAccess.Models;

namespace BusinessLogic.Mapping
{
    public class GovernorateProfile : Profile
    {
        public GovernorateProfile()
        {
            CreateMap<Governorate, GovernorateListDto>();
            CreateMap<Governorate, GovernorateDetailsDto>();

            CreateMap<AddGovernorateDto, Governorate>();
            CreateMap<UpdateGovernorateDto, Governorate>();
        }
    }
}
