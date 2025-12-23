using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.DTOs.SubscriptionPlan;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class SubscriptionPlansService
    {
        private readonly IGeneralRepository<SubscriptionPlan> _repository;
        private readonly IMapper _mapper;

        public SubscriptionPlansService(
            IGeneralRepository<SubscriptionPlan> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Get All
        public async Task<IEnumerable<GetAllSubscriptionPlanDTO>> GetAllPlans()
        {
            var plans = await _repository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<GetAllSubscriptionPlanDTO>>(plans);
        }

        // Get By Id
        public GetSubscriptionPlanByIdDTO GetPlanById(int id)
        {
            var plan = _repository.GetByID(id);
            if (plan == null) return null;

            return _mapper.Map<GetSubscriptionPlanByIdDTO>(plan);
        }

        // Add
        public async Task<int> AddPlan(AddSubscriptionPlanDTO dto)
        {
            var plan = _mapper.Map<SubscriptionPlan>(dto);
            await _repository.Add(plan);
            return plan.Id;
        }

        // Update
        public async Task<bool> UpdatePlan(int id, UpdateSubscriptionPlanDTO dto)
        {
            var exists = await _repository.IsExist(id);
            if (!exists) return false;

            var plan = _mapper.Map<SubscriptionPlan>(dto);
            plan.Id = id;

            await _repository.Update(plan);
            return true;
        }

        // Delete
        public async Task<bool> DeletePlan(int id)
        {
            if (id <= 0) return false;
            await _repository.Delete(id);
            return true;
        }
    }
}
