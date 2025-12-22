using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interface;
using BusinessLogic.ViewModel;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class CraftsmanService
    {
        IGeneralRepository<Craftsman> _craftsmanRepository;
        IMapper _mapper;
        public CraftsmanService(IGeneralRepository<Craftsman> craftsmanRepository,IMapper mapper)
        {
            _craftsmanRepository = craftsmanRepository;
            _mapper = mapper;

        }
        //GetAll
        public async Task<IEnumerable<GetAllCraftsmanDTO>> GetAllCraftsmen()
        {
            var query =await  _craftsmanRepository.GetAll()
                .Include(q => q.User)
                .Include(q => q.Profession)
                .Include(q => q.Reviews).ToListAsync();
            var res = _mapper.Map<IEnumerable<GetAllCraftsmanDTO>>(query);
            return res;

        }
        //GetBy Id
        public async Task<GetByIdCraftsmanDTO> GetByIdCraftsman(int id) {

            var query = await _craftsmanRepository.GetAll()
                .Include(q => q.User)
                .Include(q => q.Profession)
                .Include(q => q.Skills)
                    .ThenInclude(cs => cs.Skill) 
                .Include(q => q.GalleryImages)
                .Include(q => q.Reviews)
                    .ThenInclude(r => r.Reviewer) 
                .FirstOrDefaultAsync(c => c.Id == id);
            if (query == null)
            {
                return null; 
            }
            var res = _mapper.Map<GetByIdCraftsmanDTO>(query);
            return res;
        }
        //Add Craftman
        public async Task<AddCraftsmanViewModel> AddCraftsman(AddCraftsmanDTO craftsmanDTO)
        {
            // 1. Basic validation (optional)
            var userExists =await  _craftsmanRepository.IsExist(craftsmanDTO.UserId);
            
            if (!userExists) throw new Exception("User not found");

            // 2. Map DTO to Entity
            var craftsman = _mapper.Map<Craftsman>(craftsmanDTO);

            
            if (craftsmanDTO.CityIds != null && craftsmanDTO.CityIds.Any())
            {
                craftsman.WorkedCities = craftsmanDTO.CityIds.Select(cityId => new CraftsmanCity
                {
                    CityId = cityId
                }).ToList();
            }

            if (craftsmanDTO.SkillIds != null && craftsmanDTO.SkillIds.Any())
            {
                craftsman.Skills = craftsmanDTO.SkillIds.Select(skillId => new CraftsmanSkill
                {
                    SkillId = skillId
                }).ToList();
            }
          await _craftsmanRepository.Add(craftsman);
          return _mapper.Map<AddCraftsmanViewModel>(craftsman);
        }
        //Delate for craftsman
        public  async Task DeleteCraftsman(int id)
        {
            var craftsman = _craftsmanRepository.GetByIDWithTracking(id);
            if (craftsman == null)
            {
                throw new Exception("Craftsman is not Found");
            }
            await _craftsmanRepository.Delete(id);
        }
        //update all entity 
        public async Task<bool> UpdateCraftsman(int id, UpdateCraftsmanAllDTO dto)
        {

            var existingCraftsman = await _craftsmanRepository.GetByID(id);
            if (existingCraftsman == null) return false;
            _mapper.Map(dto, existingCraftsman);
            _craftsmanRepository.Update(existingCraftsman);

           return true;
        }







    }
}
