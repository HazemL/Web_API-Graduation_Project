using AutoMapper;
using BusinessLogic.Common;
using BusinessLogic.DTOs.Craftsmen;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

public class CraftsmanService : ICraftsmanService
{
    private readonly IGeneralRepository<Craftsman> _repo;
    private readonly IGeneralRepository<Gallery> _galleryRepo;
    private readonly IMapper _mapper;

    public CraftsmanService(
        IGeneralRepository<Craftsman> repo,
        IGeneralRepository<Gallery> galleryRepo,
        IMapper mapper)
    {
        _repo = repo;
        _galleryRepo = galleryRepo;
        _mapper = mapper;
    }

    // ======================
    // GET ALL
    // ======================
    public async Task<ServiceResult<IEnumerable<GetCraftsmanDto>>> GetAllAsync()
    {
        var entities = await _repo.GetAll()
            .Include(x => x.User)
                .ThenInclude(u => u.Governorate)
            .Include(x => x.User)
                .ThenInclude(u => u.City)
            .Include(x => x.GalleryImages) // ✅ الإضافة المهمة
            .Where(x => !x.IsDeleted)
            .ToListAsync();

        var data = _mapper.Map<IEnumerable<GetCraftsmanDto>>(entities);
        return ServiceResult<IEnumerable<GetCraftsmanDto>>.Ok(data);
    }

    // ======================
    // GET BY ID
    // ======================
    public async Task<ServiceResult<GetCraftsmanDto>> GetByIdAsync(int id)
    {
        var entity = await _repo.GetAll()
            .Include(x => x.User)
                .ThenInclude(u => u.Governorate)
            .Include(x => x.User)
                .ThenInclude(u => u.City)
            .Include(x => x.GalleryImages) // ✅ الإضافة المهمة
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity == null)
            return ServiceResult<GetCraftsmanDto>.Fail("Craftsman not found");

        return ServiceResult<GetCraftsmanDto>.Ok(
            _mapper.Map<GetCraftsmanDto>(entity));
    }

    // ======================
    // CREATE
    // ======================
    public async Task<ServiceResult<int>> CreateAsync(CreateCraftsmanDto dto)
    {
        var entity = _mapper.Map<Craftsman>(dto);
        entity.IsVerified = false;
        entity.CreatedAt = DateTime.UtcNow;

        await _repo.Add(entity);
        return ServiceResult<int>.Ok(entity.Id, "Craftsman created successfully");
    }

    // ======================
    // UPDATE
    // ======================
    public async Task<ServiceResult<bool>> UpdateAsync(int id, UpdateCraftsmanDto dto)
    {
        var entity = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        _mapper.Map(dto, entity);
        entity.UpdatedAt = DateTime.UtcNow;

        await _repo.Update(entity);
        return ServiceResult<bool>.Ok(true, "Updated successfully");
    }

    // ======================
    // DELETE
    // ======================
    public async Task<ServiceResult<bool>> DeleteAsync(int id)
    {
        var entity = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;

        await _repo.Update(entity);
        return ServiceResult<bool>.Ok(true, "Deleted successfully");
    }

    // =====================================================
    // UPLOAD PROFILE IMAGE (Gallery)
    // =====================================================
    public async Task<ServiceResult<bool>> UploadProfileImageAsync(
        int craftsmanId,
        string imageUrl)
    {
        var craftsman = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == craftsmanId && !x.IsDeleted);

        if (craftsman == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        // حذف الصورة القديمة
        var oldImage = await _galleryRepo.GetAll()
            .FirstOrDefaultAsync(x =>
                x.CraftsmanId == craftsmanId &&
                x.MediaType == "Profile" &&
                !x.IsDeleted);

        if (oldImage != null)
        {
            oldImage.IsDeleted = true;
            oldImage.UpdatedAt = DateTime.UtcNow;
            await _galleryRepo.Update(oldImage);
        }

        // إضافة الجديدة
        var gallery = new Gallery
        {
            CraftsmanId = craftsmanId,
            MediaUrl = imageUrl,
            MediaType = "Profile",
            Title = "Profile Image",
            Description = "Craftsman profile image",
            CreatedAt = DateTime.UtcNow
        };

        await _galleryRepo.Add(gallery);

        return ServiceResult<bool>.Ok(true, "Profile image uploaded successfully");
    }
}
