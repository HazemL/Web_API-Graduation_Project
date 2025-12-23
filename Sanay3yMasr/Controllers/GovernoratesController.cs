using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.DTOs.Governorate;
using BusinessLogic.Service;


namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernoratesController : ControllerBase
    {
        private readonly GovernoratesService _governoratesService;
        public GovernoratesController(GovernoratesService governoratesService)
        {
            _governoratesService = governoratesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGovernorates()
        {
            var governorates = await _governoratesService.GetAllGovernorates();
            if (governorates == null)
            {
                return NotFound();
            }
            return Ok(governorates);
        }
        [HttpGet("{id}")]
        public IActionResult GetGovernorateById(int id)
        {
            var governorate = _governoratesService.GetGovernorateById(id);
            if (governorate == null)
            {
                return NotFound();
            }
            return Ok(governorate);
        }
        [HttpPost]
        public async Task<IActionResult> AddGovernorate(AddGovernorateDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var newGovernorateId = await _governoratesService.AddGovernorate(dto);
            return Ok(new { id = newGovernorateId, message = "Governorate added successfully" });
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGovernorate(int id)
        {
            var result = await _governoratesService.DeleteGovernorate(id);
            if (!result) return BadRequest();
            return Ok("Governorate is Deleted");
        }
    }
}
