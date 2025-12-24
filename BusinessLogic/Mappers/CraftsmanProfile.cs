using AutoMapper;
using BusinessLogic.DTOs.Craftsmen;
using DataAccess.Models;

namespace BusinessLogic.Mapping
{
    // Mapping بين Entity و DTOs
    public class CraftsmanProfile : Profile
    {
        public CraftsmanProfile()
        {
            // Create
            CreateMap<CreateCraftsmanDto, Craftsman>();

            // Update
            CreateMap<UpdateCraftsmanDto, Craftsman>();

            // Get
            CreateMap<Craftsman, GetCraftsmanDto>();
        }
    }
}
