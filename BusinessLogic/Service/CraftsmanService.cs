using AutoMapper;
using BusinessLogic.DTOs.Craftsmen;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class CraftsmanService : ICraftsmanService
    {
        private readonly IGeneralRepository<Craftsman> _repo;
        private readonly IMapper _mapper;

        public CraftsmanService(
            IGeneralRepository<Craftsman> repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET ALL
        public async Task<IEnumerable<GetCraftsmanDto>> GetAllAsync()
        {
            var entities = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GetCraftsmanDto>>(entities);
        }

        // GET BY ID
        public async Task<GetCraftsmanDto?> GetByIdAsync(int id)
        {
            var entity = await _repo.GetAll()
                .FirstOrDefaultAsync(x => x.Id == id);

            return entity == null ? null : _mapper.Map<GetCraftsmanDto>(entity);
        }

        // CREATE
        public async Task<int> CreateAsync(CreateCraftsmanDto dto)
        {
            var entity = _mapper.Map<Craftsman>(dto);

            entity.IsVerified = false;
            entity.CreatedAt = DateTime.UtcNow;

            await _repo.Add(entity);
            return entity.Id;
        }

        // UPDATE
        public async Task<bool> UpdateAsync(int id, UpdateCraftsmanDto dto)
        {
            var entity = await _repo.GetAll()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
                return false;

            _mapper.Map(dto, entity);
            entity.UpdatedAt = DateTime.UtcNow;

            return true;
        }

        // DELETE (Soft Delete)
        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _repo.GetAll()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
                return false;

            entity.IsDeleted = true;
            entity.UpdatedAt = DateTime.UtcNow;

            return true;
        }
    }
}
