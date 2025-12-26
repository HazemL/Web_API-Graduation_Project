using AutoMapper;
using BusinessLogic.DTOs.Craftsmen;
using DataAccess.Models;

public class CraftsmanProfile : Profile
{
    public CraftsmanProfile()
    {
        CreateMap<CreateCraftsmanDto, Craftsman>();
        CreateMap<UpdateCraftsmanDto, Craftsman>();

        CreateMap<Craftsman, GetCraftsmanDto>()
            .ForMember(d => d.FullName,
                o => o.MapFrom(s => s.User.FullName))
            .ForMember(d => d.GovernorateName,
                o => o.MapFrom(s => s.User.Governorate != null
                    ? s.User.Governorate.Name
                    : null))
            .ForMember(d => d.CityName,
                o => o.MapFrom(s => s.User.City != null
                    ? s.User.City.Name
                    : null));
    }
}
