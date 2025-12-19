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
       
        

        


    }
}
