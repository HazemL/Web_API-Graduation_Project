using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Report;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class ReportsService
    {
        private readonly IGeneralRepository<Report> _reportRepository;
        private readonly IMapper _mapper;

        public ReportsService(
            IGeneralRepository<Report> reportRepository,
            IMapper mapper)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
        }

        // Get All
        public async Task<IEnumerable<GetAllReportDTO>> GetAllReports()
        {
            var list = await _reportRepository.GetAll().ToListAsync();
            if (list == null) return null;

            return _mapper.Map<IEnumerable<GetAllReportDTO>>(list);
        }

        // Get By Id
        public GetReportByIdDTO GetReportById(int id)
        {
            var report = _reportRepository.GetByID(id);
            if (report == null) return null;

            return _mapper.Map<GetReportByIdDTO>(report);
        }

        // Add
        public async Task<int> AddReport(AddReportDTO dto)
        {
            var report = _mapper.Map<Report>(dto);
            await _reportRepository.Add(report);
            return report.Id;
        }

        // Resolve (Admin)
        public async Task<bool> ResolveReport(int id)
        {
            var exists = await _reportRepository.IsExist(id);
            if (!exists) return false;

            var report = await _reportRepository.GetByID(id); // Await here
            if (report == null) return false; // Defensive: handle null

            report.IsResolved = true;

            await _reportRepository.Update(report);
            return true;
        }

        // Delete
        public async Task<bool> DeleteReport(int id)
        {
            if (id <= 0) return false;
            await _reportRepository.Delete(id);
            return true;
        }
    }
}