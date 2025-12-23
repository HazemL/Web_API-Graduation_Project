using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Review;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ReviewsService _reviewsService;

        public ReviewsController(ReviewsService reviewsService)
        {
            _reviewsService = reviewsService;
        }

        [HttpGet]
        public async Task<IActionResult> Reviews()
        {
            var result = await _reviewsService.GetAllReviews();
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Review(int id)
        {
            var result = _reviewsService.GetReviewById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AddReviewDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var id = await _reviewsService.AddReview(dto);
            return Ok(new { id, message = "Review added successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReview(int id, UpdateReviewDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _reviewsService.UpdateReview(id, dto);
            return Ok("Review updated successfully");
        }

        [HttpPut("{id}/approve")]
        public async Task<IActionResult> ApproveReview(int id)
        {
            await _reviewsService.ApproveReview(id);
            return Ok("Review approved");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await _reviewsService.DeleteReview(id);
            return Ok("Review deleted successfully");
        }
    }
}
