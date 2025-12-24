using AutoMapper;
using BusinessLogic.DTOs.Users;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, GetUserDto>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}
