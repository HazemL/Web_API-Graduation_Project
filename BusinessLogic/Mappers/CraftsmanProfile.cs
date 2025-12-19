using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class CraftsmanProfile : Profile
    {
    
       public CraftsmanProfile() {
            // Mapping  GetAll
            CreateMap<Craftsman, GetAllCraftsmanDTO>()
           .ForMember(dest => dest.ProfessionName,
                      opt => opt.MapFrom(src => src.Profession.Name))
           .ForMember(dest => dest.ProfileImageUrl,
                      opt => opt.MapFrom(src => src.User.ProfileImage))

           .ForMember(dest => dest.AverageRating,
                      opt => opt.MapFrom(src => src.Reviews.Any() ? src.Reviews.Average(r => r.Stars) : 0))
           .ForMember(dest => dest.ReviewsCount,
                      opt => opt.MapFrom(src => src.Reviews.Count));
            //map to getByid
            CreateMap<Craftsman, GetByIdCraftsmanDTO>()
            .ForMember(dest => dest.ProfessionName, opt => opt.MapFrom(src => src.Profession.Name))
            .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => src.Skills.Select(s => s.Skill.Name)))
            .ForMember(dest => dest.GalleryUrls, opt => opt.MapFrom(src => src.GalleryImages.Select(g => g.MediaUrl)))
            .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews));
            CreateMap<Review, ReviewDTO>()
                .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Reviewer.FullName));
        }
      
    }
}
