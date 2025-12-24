using AutoMapper;

using BusinessLogic.DTOs.Skills;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class SkillService : ISkillService
    {
        private readonly IGeneralRepository<Skill> _repo;
        private readonly IMapper _mapper;

        public SkillService(IGeneralRepository<Skill> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET /api/skills
        public async Task<IEnumerable<GetSkillDto>> GetAllAsync()
        {
            var skills = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GetSkillDto>>(skills);
        }

        // GET /api/skills/{id}
        public async Task<GetSkillDto?> GetByIdAsync(int id)
        {
            var skill = await _repo.GetByID(id);
            return skill == null ? null : _mapper.Map<GetSkillDto>(skill);
        }

        // POST
        public async Task AddAsync(AddSkillDto dto, string createdBy)
        {
            var skill = _mapper.Map<Skill>(dto);
            skill.CreatedBy = createdBy;
            skill.CreatedAt = DateTime.UtcNow;

            await _repo.Add(skill);
        }

        // PUT
        public async Task UpdateAsync(int id, UpdateSkillDto dto, string updatedBy)
        {
            var skill = await _repo.GetByIDWithTracking(id);
            if (skill == null)
                throw new Exception("Skill not found");

            _mapper.Map(dto, skill);
            skill.UpdatedBy = updatedBy;
            skill.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(skill);
        }

        // DELETE (Soft Delete)
        public async Task DeleteAsync(int id)
        {
            await _repo.Delete(id);
        }
    }
}
