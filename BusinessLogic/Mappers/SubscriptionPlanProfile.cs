using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.DTOs.SubscriptionPlan;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class SubscriptionPlanProfile : Profile
    {
        public SubscriptionPlanProfile()
        {
            CreateMap<SubscriptionPlan, GetAllSubscriptionPlanDTO>();

           
            CreateMap<SubscriptionPlan, GetSubscriptionPlanByIdDTO>()
                .ForMember(dest => dest.SubscribersCount,
                    opt => opt.MapFrom(src => 0));

            CreateMap<AddSubscriptionPlanDTO, SubscriptionPlan>().ReverseMap();
            CreateMap<UpdateSubscriptionPlanDTO, SubscriptionPlan>().ReverseMap();
        }
    }
}
