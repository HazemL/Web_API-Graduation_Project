using AutoMapper;
using BusinessLogic.Common;
using BusinessLogic.DTOs.Craftsmen;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

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

    public async Task<ServiceResult<IEnumerable<GetCraftsmanDto>>> GetAllAsync()
    {
        var entities = await _repo.GetAll()
            .Include(x => x.User)
                .ThenInclude(u => u.Governorate)
            .Include(x => x.User)
                .ThenInclude(u => u.City)
            .ToListAsync();

        var data = _mapper.Map<IEnumerable<GetCraftsmanDto>>(entities);
        return ServiceResult<IEnumerable<GetCraftsmanDto>>.Ok(data);
    }

    public async Task<ServiceResult<GetCraftsmanDto>> GetByIdAsync(int id)
    {
        var entity = await _repo.GetAll()
            .Include(x => x.User)
                .ThenInclude(u => u.Governorate)
            .Include(x => x.User)
                .ThenInclude(u => u.City)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (entity == null)
            return ServiceResult<GetCraftsmanDto>.Fail("Craftsman not found");

        return ServiceResult<GetCraftsmanDto>.Ok(
            _mapper.Map<GetCraftsmanDto>(entity));
    }

    public async Task<ServiceResult<int>> CreateAsync(CreateCraftsmanDto dto)
    {
        var entity = _mapper.Map<Craftsman>(dto);
        entity.IsVerified = false;
        entity.CreatedAt = DateTime.UtcNow;

        await _repo.Add(entity);
        return ServiceResult<int>.Ok(entity.Id, "Craftsman created successfully");
    }

    public async Task<ServiceResult<bool>> UpdateAsync(int id, UpdateCraftsmanDto dto)
    {
        var entity = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == id);

        if (entity == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        _mapper.Map(dto, entity);
        entity.UpdatedAt = DateTime.UtcNow;

        return ServiceResult<bool>.Ok(true, "Updated successfully");
    }

    public async Task<ServiceResult<bool>> DeleteAsync(int id)
    {
        var entity = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == id);

        if (entity == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;

        return ServiceResult<bool>.Ok(true, "Deleted successfully");
    }
}
