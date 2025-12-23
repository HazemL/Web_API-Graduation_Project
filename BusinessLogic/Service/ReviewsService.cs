using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Review;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class ReviewsService
    {
        private readonly IGeneralRepository<Review> _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewsService(
            IGeneralRepository<Review> reviewRepository,
            IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        // Get All
        public async Task<IEnumerable<GetAllReviewDTO>> GetAllReviews()
        {
            var list = await _reviewRepository.GetAll().ToListAsync();
            if (list == null) return null;

            return _mapper.Map<IEnumerable<GetAllReviewDTO>>(list);
        }

        // Get By Id
        public GetReviewByIdDTO GetReviewById(int id)
        {
            var review = _reviewRepository.GetByID(id);
            if (review == null) return null;

            return _mapper.Map<GetReviewByIdDTO>(review);
        }

        // Add
        public async Task<int> AddReview(AddReviewDTO dto)
        {
            var review = _mapper.Map<Review>(dto);
            await _reviewRepository.Add(review);
            return review.Id;
        }

        // Approve Review (Admin)
        public async Task<bool> ApproveReview(int id)
        {
            var exists = await _reviewRepository.IsExist(id);
            if (!exists) return false;

            var entity = await _reviewRepository.GetByID(id);
            if (entity == null) return false;

            entity.IsApproved = true;

            await _reviewRepository.Update(entity);
            return true;
        }

        // Delete
        public async Task<bool> DeleteReview(int id)
        {
            if (id <= 0) return false;
            await _reviewRepository.Delete(id);
            return true;
        }

        // Update
        public async Task<bool> UpdateReview(int id, UpdateReviewDTO dto)
        {
            var exists = await _reviewRepository.IsExist(id);
            if (!exists) return false;

            var review = _mapper.Map<Review>(dto);
            review.Id = id;

            await _reviewRepository.Update(review);
            return true;
        }
    }
}