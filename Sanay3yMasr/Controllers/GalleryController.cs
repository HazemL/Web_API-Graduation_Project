using BusinessLogic.DTOs;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly GalleryService _galleryService;

        public GalleryController(GalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public async Task<IActionResult> Gallery()
        {
            var result = await _galleryService.GetAllGallery();
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GalleryItem(int id)
        {
            var result = _galleryService.GetGalleryById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddGallery(AddGalleryDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var id = await _galleryService.AddGallery(dto);
            return Ok(new { id, message = "Gallery item added successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGallery(int id, UpdateGalleryDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _galleryService.UpdateGallery(id, dto);
            return Ok("Gallery updated successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGallery(int id)
        {
            await _galleryService.DeleteGallery(id);
            return Ok("Gallery deleted successfully");
        }
    }
}