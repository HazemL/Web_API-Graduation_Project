using System.Threading.Tasks;
using BusinessLogic.Service;
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
    }
}
