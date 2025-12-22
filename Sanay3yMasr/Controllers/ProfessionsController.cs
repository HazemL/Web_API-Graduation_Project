using System.Threading.Tasks;
using BusinessLogic.DTOs;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionsController : ControllerBase
    {
        ProfessionsService _professionsService;
        public ProfessionsController(ProfessionsService professionsService)
        {
            _professionsService = professionsService;
        }
        [HttpGet]
        public async Task<IActionResult> Professions() {
            var professions =await _professionsService.GetAllProfessions();
            if (professions == null)
            {
                return NotFound();
            }
            return Ok(professions);
        }
        [HttpGet("id")]
        public IActionResult Profession(int id) { 

            var profession = _professionsService.GetProfessionByID(id);
            if(profession == null)
            {
                return NotFound();
            }
            return Ok(profession);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddProfessionsDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = await _professionsService.AddProfession(dto);

            return CreatedAtAction(nameof(_professionsService.GetProfessionByID), new { id = id }, dto);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id) { 
           await _professionsService.DeleteProfession(id);
            return Ok("Profession is Deleted");
        
        }
        [Authorize(Roles ="Admin")]
        [HttpPut("id")]
        public async Task<IActionResult> Update(int id, UpdateProfessionAllDTO dto) {

            if (!ModelState.IsValid) return BadRequest("Profession not valid");
            var sucess =await _professionsService.UpdateProfession(id, dto);
            if (!sucess)
                return NotFound($"Profession with ID {id} not found.");

            return Ok(new { message = "Profession updated successfully" });
        }


    }
}
