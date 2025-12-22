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
    public class ProfessionProfile :Profile
    {
        public ProfessionProfile()
        {
            // Mapping  GetAll
            CreateMap<Profession, GetAllProfessionDTO>();

            // Mapping  GetById
            CreateMap<Profession, GetByIdProfessionDTO>()
                .ForMember(dest => dest.CraftsmenCount,
                           opt => opt.MapFrom(src => src.Craftsmen.Count));
            //map to add
            CreateMap<AddProfessionsDTO, Profession>().ReverseMap();
            //map to update
            CreateMap<UpdateProfessionAllDTO, Profession>().ReverseMap();
        }
    }
}
