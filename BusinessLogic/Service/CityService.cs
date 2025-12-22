using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interface;
using BusinessLogic.Repository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class CityService
    {
        IGeneralRepository<City> _cityRepository;
        IMapper _mapper;
        public CityService(IGeneralRepository<City> cityRepository,IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper  = mapper;
        }
        //Get all City

        public async Task<IEnumerable<GetAllCityDTO>> GetAllCity()
        {
            var query =await  _cityRepository.GetAll()
                .Include(q => q.Governorate)
                .ToListAsync();
            if(query == null)
            {
                return null;
            }
            var res = _mapper.Map<IEnumerable<GetAllCityDTO>>(query);
            return res;

        }
        //Get city by id
        public async Task<GetByIdCityDTO> GetCityById(int id) {
            var query = await _cityRepository.GetAll()
                .Include(q => q.Governorate)
                .Include(q => q.CraftsmanCities)
                .FirstOrDefaultAsync(q => q.Id==id);

            if (query == null) return null;
            var res = _mapper.Map<GetByIdCityDTO>(query);

            return res;
        }
        public async Task<bool> AddCity(AddCityDTO addCityDTO)
        {
            
            if (addCityDTO == null) return false;
            var city = _mapper.Map<City>(addCityDTO);
            if(city == null) return false;
            var exists = await _cityRepository.IsExist(city.GovernorateId);
            if (!exists) throw new Exception("City already exists in this governorate");
            await  _cityRepository.Add(city);
            return true;

        }
        public async Task<bool> DeleteCity(int id)
        {
            if(id <= 0) return false;
            await _cityRepository.Delete(id);
            return true;  
        }
        public async Task<bool> UpdateCity(int id, UpdateCityAllDTO updateCityDTO)
        {
            var existCity =await _cityRepository.IsExist(id);
            if(!existCity) return false;
            var newCity = _mapper.Map<City>(updateCityDTO);
            if (newCity == null) return false;
            await _cityRepository.Update(newCity);
            return true;

        }





     }
}
