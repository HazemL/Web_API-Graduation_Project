using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    internal class GalleryProfile : Profile
    {
        public GalleryProfile()
        {
            CreateMap<Gallery, GetAllGalleryDTO>();
            CreateMap<Gallery, GetGalleryByIdDTO>();

            CreateMap<AddGalleryDTO, Gallery>().ReverseMap();
            CreateMap<UpdateGalleryDTO, Gallery>().ReverseMap();
        }
    }
}
