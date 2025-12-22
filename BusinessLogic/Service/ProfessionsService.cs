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
    public class ProfessionsService
    {
        IGeneralRepository<Profession> _professionRepository;
        IMapper _mapper;
        public ProfessionsService(IGeneralRepository<Profession> professionRepository, IMapper mapper)
        {
            _professionRepository = professionRepository;
            _mapper = mapper;
        }
        //GetAllProfessions
        public async Task<IEnumerable<GetAllProfessionDTO>> GetAllProfessions()
        {
            var query = await _professionRepository.GetAll().ToListAsync();
            var res = _mapper.Map<IEnumerable<GetAllProfessionDTO>>(query);
            return res;
            
        }
        //Get by id
        public async Task<GetByIdProfessionDTO> GetProfessionByID(int id)
        {
            var query = await _professionRepository.GetByID(id);
            if (query == null)
            {
                return null;
            }
            var res = _mapper.Map<GetByIdProfessionDTO>(query);
            
            return res;
        }
        public async Task<int> AddProfession(AddProfessionsDTO dto)
        {
            var profession = _mapper.Map<Profession>(dto);

            await _professionRepository.Add(profession);
            return profession.Id;
        }
        public async Task<bool> DeleteProfession(int id) {
            if (id <= 0) throw new Exception("Id is not valid");
            await _professionRepository.Delete(id);
            return true;
        }
        public async Task<bool> UpdateProfession(int id,UpdateProfessionAllDTO dto)
        {
            var existProfession = await _professionRepository.IsExist(id);
            if(!existProfession) return false;
            var newProfession = _mapper.Map<Profession>(dto);
            await _professionRepository.Update(newProfession);
            return true;


        }





    }
}
