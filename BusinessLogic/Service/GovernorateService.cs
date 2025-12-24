using AutoMapper;
using BusinessLogic.DTOs.Governorates;
using BusinessLogic.Interface;
using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class GovernorateService : IGovernorateService
    {
        private readonly IGeneralRepository<Governorate> _repo;
        private readonly IMapper _mapper;

        public GovernorateService(
            IGeneralRepository<Governorate> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // ================= GET ALL =================
        public async Task<IEnumerable<GovernorateListDto>> GetAllAsync()
        {
            var data = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GovernorateListDto>>(data);
        }

        // ================= GET BY ID =================
        public async Task<GovernorateDetailsDto?> GetByIdAsync(int id)
        {
            var entity = await _repo.GetAll()
                .Include(x => x.Cities)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) return null;

            var dto = _mapper.Map<GovernorateDetailsDto>(entity);
            dto.CitiesCount = entity.Cities?.Count ?? 0;

            return dto;
        }

        // ================= ADD =================
        public async Task AddAsync(AddGovernorateDto dto)
        {
            var entity = _mapper.Map<Governorate>(dto);
            await _repo.Add(entity);
        }

        // ================= UPDATE =================
        public async Task UpdateAsync(int id, UpdateGovernorateDto dto)
        {
            var entity = await _repo.GetByIDWithTracking(id);
            if (entity == null)
                throw new Exception("Governorate not found");

            _mapper.Map(dto, entity);
            entity.UpdatedAt = DateTime.UtcNow;
        }

        // ================= DELETE (Soft) =================
        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(id);
        }
    }
}
