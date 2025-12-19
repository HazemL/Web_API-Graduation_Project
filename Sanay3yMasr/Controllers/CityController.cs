using System.Threading.Tasks;
using BusinessLogic.Service;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        CityService _cityService;
        public CityController(CityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        public async Task<IActionResult> Cities()
        {
            var cities =await _cityService.GetAllCity();
            if (cities == null) return NoContent();
            return Ok(cities);
        }
        [HttpGet("id")]
        public IActionResult City(int id)
        {
            var city = _cityService.GetCityById(id);
            if (city == null) return NoContent();
            return Ok(city);
        }


    }
}
