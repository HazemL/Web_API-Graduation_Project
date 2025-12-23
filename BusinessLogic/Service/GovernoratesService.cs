using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Governorate;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class GovernoratesService
    {
        private readonly IGeneralRepository<Governorate> _governorateRepository;
        private readonly IMapper _mapper;

        public GovernoratesService(
            IGeneralRepository<Governorate> governorateRepository,
            IMapper mapper)
        {
            _governorateRepository = governorateRepository;
            _mapper = mapper;
        }

        // Get All
        public async Task<IEnumerable<GetAllGovernorateDTO>> GetAllGovernorates()   
        {
            var query = await _governorateRepository.GetAll().ToListAsync();
            if (query == null) return null;

            return _mapper.Map<IEnumerable<GetAllGovernorateDTO>>(query);
        }

        // Get By Id
        public GetByIdGovernorateDTO GetGovernorateById(int id)
        {
            var governorate = _governorateRepository.GetByID(id);
            if (governorate == null) return null;

            return _mapper.Map<GetByIdGovernorateDTO>(governorate);
        }

        // Add
        public async Task<int> AddGovernorate(AddGovernorateDTO dto)
        {
            var governorate = _mapper.Map<Governorate>(dto);
            await _governorateRepository.Add(governorate);
            return governorate.Id;
        }

        // Delete
        public async Task<bool> DeleteGovernorate(int id)
        {
            if (id <= 0) return false;
            await _governorateRepository.Delete(id);
            return true;
        }

        // Update
        public async Task<bool> UpdateGovernorate(int id, UpdateGovernorateDTO dto)
        {
            var exists = await _governorateRepository.IsExist(id);
            if (!exists) return false;

            var governorate = _mapper.Map<Governorate>(dto);
            governorate.Id = id;

            await _governorateRepository.Update(governorate);
            return true;
        }
    }
}
