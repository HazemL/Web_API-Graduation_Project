using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class SkillsService
    {
        IGeneralRepository<Skill> _skillRepository;
        IMapper _mapper;
        public SkillsService(IGeneralRepository<Skill> skillRepository, IMapper mapper)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
        }
        //Get All Skills
        public async Task<IEnumerable<GetAllSkillDTO>> GetAllSkill()
        {
            var query = await _skillRepository.GetAll().ToListAsync();
            if(query == null)
            {
                return null;
            }
            var res = _mapper.Map<IEnumerable<GetAllSkillDTO>>(query);
            return res;
        }
        // Get skill by id 
        public GetByIdSkillDTO GetSkillById(int id)
        {
            var query = _skillRepository.GetByID(id);
            if(query == null)
            {
                return null;
            }
            var res = _mapper.Map<GetByIdSkillDTO>(query);
            return res;
        }
    }
}
