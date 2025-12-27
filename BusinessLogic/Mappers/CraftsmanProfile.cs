using AutoMapper;
using BusinessLogic.DTOs.Craftsmen;
using DataAccess.Models;

public class CraftsmanProfile : Profile
{
    public CraftsmanProfile()
    {
        // Create / Update
        CreateMap<CreateCraftsmanDto, Craftsman>();
        CreateMap<UpdateCraftsmanDto, Craftsman>();

        // Entity -> DTO
        CreateMap<Craftsman, GetCraftsmanDto>()
            // User info
            .ForMember(d => d.FullName,
                o => o.MapFrom(s => s.User!.FullName))
            .ForMember(d => d.Phone,
                o => o.MapFrom(s => s.User!.Phone))
            .ForMember(d => d.ProfileImageUrl,
                o => o.MapFrom(s => s.User!.ProfileImage))

            // Location
            .ForMember(d => d.GovernorateName,
                o => o.MapFrom(s => s.User!.Governorate != null
                    ? s.User.Governorate.Name
                    : null))
            .ForMember(d => d.CityName,
                o => o.MapFrom(s => s.User!.City != null
                    ? s.User.City.Name
                    : null));
    }
}
