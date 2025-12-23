using AutoMapper;
using BusinessLogic.DTOs.Governorate;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    internal class GovernorateProfile: Profile
    {
        public GovernorateProfile()
        {
            // Get All
            CreateMap<Governorate, GetAllGovernorateDTO>();

            // Get By Id
            CreateMap<Governorate, GetByIdGovernorateDTO>()
                .ForMember(dest => dest.CitiesCount,
                    opt => opt.MapFrom(src =>
                        src.Cities != null ? src.Cities.Count : 0));

            // Add
            CreateMap<AddGovernorateDTO, Governorate>().ReverseMap();

            // Update
            CreateMap<UpdateGovernorateDTO, Governorate>().ReverseMap();
        }

    }
}
