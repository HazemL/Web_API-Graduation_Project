using AutoMapper;
using BusinessLogic.DTOs.Professions;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    // Business Logic الخاص بالمهن
    public class ProfessionService : IProfessionService
    {
        private readonly IGeneralRepository<Profession> _repo;
        private readonly IMapper _mapper;

        public ProfessionService(
            IGeneralRepository<Profession> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // ================= GET ALL =================
        public async Task<IEnumerable<ProfessionResponseDto>> GetAllAsync()
        {
            var list = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ProfessionResponseDto>>(list);
        }

        // ================= GET BY ID =================
        public async Task<ProfessionResponseDto?> GetByIdAsync(int id)
        {
            var entity = await _repo.GetByID(id);
            if (entity == null) return null;

            return _mapper.Map<ProfessionResponseDto>(entity);
        }

        // ================= CREATE =================
        public async Task CreateAsync(CreateProfessionDto dto)
        {
            var entity = _mapper.Map<Profession>(dto);
            entity.CreatedAt = DateTime.UtcNow;

            await _repo.Add(entity);
        }

        // ================= UPDATE (✔ FIXED) =================
        public async Task UpdateAsync(int id, UpdateProfessionDto dto)
        {
            // لازم Tracking
            var entity = await _repo.GetByIDWithTracking(id);
            if (entity == null)
                throw new Exception("Profession not found");

            // Map التعديلات
            _mapper.Map(dto, entity);

            entity.UpdatedAt = DateTime.UtcNow;

            // 🔥 ده الحل اللي كان ناقص
            await _repo.Update(entity);
        }

        // ================= DELETE =================
        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(id);
        }
    }
}
