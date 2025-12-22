using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.ViewModel;
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
            //map to add 
            //  Map Input DTO to Entity
            CreateMap<AddCraftsmanDTO, Craftsman>()
                .ForMember(dest => dest.WorkedCities, opt => opt.Ignore()) 
                .ForMember(dest => dest.Skills, opt => opt.Ignore())       
                .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(src => false)).ReverseMap();
            CreateMap<UpdateCraftsmanAllDTO, Craftsman>()
             .ForMember(dest => dest.WorkedCities, opt => opt.MapFrom(src =>
                 src.CityIds.Select(id => new CraftsmanCity { CityId = id })))

             .ForMember(dest => dest.Skills, opt => opt.MapFrom(src =>
                 src.SkillIds.Select(id => new CraftsmanSkill { SkillId = id })))

             .ForMember(dest => dest.GalleryImages, opt => opt.MapFrom(src =>
                 src.GalleryImageUrls.Select(url => new Gallery { MediaUrl = url }))).ReverseMap();


            //  Map Entity to Output ViewModel
            CreateMap<Craftsman, AddCraftsmanViewModel>()
                .ForMember(dest => dest.ProfessionName, opt => opt.MapFrom(src => src.Profession != null ? src.Profession.Name : ""))
                .ForMember(dest => dest.Cities, opt => opt.MapFrom(src => src.WorkedCities.Select(x => x.City.Name).ToList()))
                .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => src.Skills.Select(x => x.Skill.Name).ToList()));

            
            CreateMap<UpdateCraftsmanAllViewModel, Craftsman>()
                .ForMember(dest => dest.WorkedCities, opt => opt.MapFrom(src =>
                    src.CityIds.Select(id => new CraftsmanCity { CityId = id })))
                .ForMember(dest => dest.Skills, opt => opt.MapFrom(src =>
                    src.SkillIds.Select(id => new CraftsmanSkill { SkillId = id })))
                .ForMember(dest => dest.GalleryImages, opt => opt.MapFrom(src =>
                    src.GalleryImageUrls.Select(url => new Gallery { MediaUrl = url })));

            CreateMap<Craftsman, UpdateCraftsmanAllViewModel>()
                .ForMember(dest => dest.CityIds, opt => opt.MapFrom(src => src.WorkedCities.Select(c => c.CityId)))
                .ForMember(dest => dest.SkillIds, opt => opt.MapFrom(src => src.Skills.Select(s => s.SkillId)))
                .ForMember(dest => dest.GalleryImageUrls, opt => opt.MapFrom(src => src.GalleryImages.Select(g => g.MediaUrl)));

        }
      
    }
}
