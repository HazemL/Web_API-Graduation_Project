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

    // ================= GET ALL =================
    public async Task<ServiceResult<IEnumerable<GetCraftsmanDto>>> GetAllAsync()
    {
        var list = await _repo.GetAll()
            .Include(x => x.User)
                .ThenInclude(u => u.Governorate)
            .Include(x => x.User)
                .ThenInclude(u => u.City)
            .Include(x => x.GalleryImages)
            .Where(x => !x.IsDeleted)
            .ToListAsync();

        return ServiceResult<IEnumerable<GetCraftsmanDto>>
            .Ok(_mapper.Map<IEnumerable<GetCraftsmanDto>>(list));
    }

    // ================= GET BY ID =================
    public async Task<ServiceResult<GetCraftsmanDto>> GetByIdAsync(int id)
    {
        var entity = await _repo.GetAll()
            .Include(x => x.User)
                .ThenInclude(u => u.Governorate)
            .Include(x => x.User)
                .ThenInclude(u => u.City)
            .Include(x => x.GalleryImages)
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity == null)
            return ServiceResult<GetCraftsmanDto>.Fail("Craftsman not found");

        return ServiceResult<GetCraftsmanDto>
            .Ok(_mapper.Map<GetCraftsmanDto>(entity));
    }

    // ================= CREATE =================
    public async Task<ServiceResult<int>> CreateAsync(CreateCraftsmanDto dto)
    {
        var entity = _mapper.Map<Craftsman>(dto);
        entity.IsVerified = false;
        entity.CreatedAt = DateTime.UtcNow;

        await _repo.Add(entity);
        return ServiceResult<int>.Ok(entity.Id);
    }

    // ================= UPDATE (FULL PROFILE) =================
    public async Task<ServiceResult<bool>> UpdateAsync(
        int id,
        UpdateCraftsmanProfileDto dto)
    {
        var craftsman = await _repo.GetAll()
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (craftsman == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        // ---------- USER ----------
        craftsman.User!.FullName = dto.FullName;
        craftsman.User.Phone = dto.Phone;
        craftsman.User.GovernorateId = dto.GovernorateId;
        craftsman.User.CityId = dto.CityId;

        // ---------- CRAFTSMAN ----------
        craftsman.ProfessionId = dto.ProfessionId;
        craftsman.Bio = dto.Bio;
        craftsman.ExperienceYears = dto.ExperienceYears;
        craftsman.MinPrice = dto.MinPrice;
        craftsman.MaxPrice = dto.MaxPrice;
        craftsman.UpdatedAt = DateTime.UtcNow;

        await _repo.Update(craftsman);
        return ServiceResult<bool>.Ok(true);
    }

    // ================= DELETE =================
    public async Task<ServiceResult<bool>> DeleteAsync(int id)
    {
        var entity = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        entity.IsDeleted = true;
        await _repo.Update(entity);

        return ServiceResult<bool>.Ok(true);
    }

    // ================= UPLOAD IMAGE =================
    public async Task<ServiceResult<bool>> UploadProfileImageAsync(
        int craftsmanId,
        string imageUrl)
    {
        var craftsman = await _repo.GetAll()
            .FirstOrDefaultAsync(x => x.Id == craftsmanId && !x.IsDeleted);

        if (craftsman == null)
            return ServiceResult<bool>.Fail("Craftsman not found");

        var old = await _galleryRepo.GetAll()
            .FirstOrDefaultAsync(x =>
                x.CraftsmanId == craftsmanId &&
                x.MediaType == "Profile" &&
                !x.IsDeleted);

        if (old != null)
        {
            old.IsDeleted = true;
            await _galleryRepo.Update(old);
        }

        await _galleryRepo.Add(new Gallery
        {
            CraftsmanId = craftsmanId,
            MediaUrl = imageUrl,
            MediaType = "Profile",
            Title = "Profile Image",
            Description = "Profile image",
            CreatedAt = DateTime.UtcNow
        });

        return ServiceResult<bool>.Ok(true);
    }
}
