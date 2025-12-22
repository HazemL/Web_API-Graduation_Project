using System.Threading.Tasks;
using BusinessLogic.DTOs;
using BusinessLogic.Service;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
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
        [HttpPost]
        public async Task<IActionResult> AddCity([FromBody] AddCityDTO dto)
        {
            if(!ModelState.IsValid) return BadRequest();
            var result = await _cityService.AddCity(dto);
            if (!result) return BadRequest("Could not add city");
            return Ok("City added successfully");
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id) { 
           await _cityService.DeleteCity(id);
           return Ok("City is Deleted");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCityAllDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var isUpdated = await _cityService.UpdateCity(id, dto);

            if (!isUpdated)
                return NotFound($"City with ID {id} not found or no changes occurred.");

            return Ok(new { message = "City updated successfully" });
        }


    }
}
