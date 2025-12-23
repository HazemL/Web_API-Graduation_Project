using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Report;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, GetAllReportDTO>();
            CreateMap<Report, GetReportByIdDTO>();

            CreateMap<AddReportDTO, Report>().ReverseMap();
        }
    }
}
