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
    public class SkillProfile : Profile
    {
        public SkillProfile() {
            //GetAll
            CreateMap<Skill, GetAllSkillDTO>();

            // GetById       
            CreateMap<Skill, GetByIdSkillDTO>()
                .ForMember(dest => dest.CraftsmenCount,
                           opt => opt.MapFrom(src => src.CraftsmanSkills != null ? src.CraftsmanSkills.Count : 0));



        }
    }
}
