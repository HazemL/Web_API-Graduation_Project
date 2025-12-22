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
    public class CityProfile : Profile
    {
        public CityProfile() {
            //   GetAll    
            CreateMap<City, GetAllCityDTO>()
                .ForMember(dest => dest.GovernorateName, opt => opt.MapFrom(src => src.Governorate.Name))
                .ForMember(dest => dest.GovernorateArabicName, opt => opt.MapFrom(src => src.Governorate.ArabicName));

            //   GetById       
            CreateMap<City, GetByIdCityDTO>()
                .ForMember(dest => dest.GovernorateName, opt => opt.MapFrom(src => src.Governorate.Name))
                .ForMember(dest => dest.CraftsmenCount, opt => opt.MapFrom(src => src.CraftsmanCities != null ? src.CraftsmanCities.Count : 0));
            //map to add
            CreateMap<City, AddCityDTO>().ReverseMap();
            //map to update
            CreateMap<UpdateCityAllDTO , City>().ReverseMap();
       


    }
    }
}
