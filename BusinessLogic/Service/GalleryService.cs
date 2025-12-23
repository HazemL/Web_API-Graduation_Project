using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class GalleryService
    {
        private readonly IGeneralRepository<Gallery> _galleryRepository;
        private readonly IMapper _mapper;

        public GalleryService(
            IGeneralRepository<Gallery> galleryRepository,
            IMapper mapper)
        {
            _galleryRepository = galleryRepository;
            _mapper = mapper;
        }

        // Get All
        public async Task<IEnumerable<GetAllGalleryDTO>> GetAllGallery()
        {
            var list = await _galleryRepository.GetAll().ToListAsync();
            if (list == null) return null;

            return _mapper.Map<IEnumerable<GetAllGalleryDTO>>(list);
        }

        // Get By Id
        public GetGalleryByIdDTO GetGalleryById(int id)
        {
            var gallery = _galleryRepository.GetByID(id);
            if (gallery == null) return null;

            return _mapper.Map<GetGalleryByIdDTO>(gallery);
        }

        // Add
        public async Task<int> AddGallery(AddGalleryDTO dto)
        {
            var gallery = _mapper.Map<Gallery>(dto);
            await _galleryRepository.Add(gallery);
            return gallery.Id;
        }

        // Delete
        public async Task<bool> DeleteGallery(int id)
        {
            if (id <= 0) return false;
            await _galleryRepository.Delete(id);
            return true;
        }

        // Update
        public async Task<bool> UpdateGallery(int id, UpdateGalleryDTO dto)
        {
            var exists = await _galleryRepository.IsExist(id);
            if (!exists) return false;

            var gallery = _mapper.Map<Gallery>(dto);
            gallery.Id = id;

            await _galleryRepository.Update(gallery);
            return true;
        }
    }
}
