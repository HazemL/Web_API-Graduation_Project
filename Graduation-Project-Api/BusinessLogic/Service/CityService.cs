using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interface;
using DataAccess.Models;

namespace BusinessLogic.Service
{
    public class CityService
    {
        ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IEnumerable<City> GetAllCity()
        {
           var res =  _cityRepository.GetAll().ToList();
           return res;
        }
        public async Task<City> GetCity(int id)
        {
           var res = await _cityRepository.GetByID(id);
           return res;
        }
        public async Task AddCity(City city) { 
           await _cityRepository.Add(city);
            
        }
        public async Task DelateCity(int id)
        {
           await _cityRepository.Delete(id);
        }
        public void UpdateCity(City city, string name) { 
            _cityRepository.UpdateInclude(city, name);
        
        }

      

    }
}
