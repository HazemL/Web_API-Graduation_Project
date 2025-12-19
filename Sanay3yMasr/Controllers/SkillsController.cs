using System.Threading.Tasks;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        SkillsService _skillsService;
        public SkillsController(SkillsService skillsService) { 
            _skillsService = skillsService;
        
        }
        [HttpGet]
        public async Task<IActionResult> Skills() {
            var skills =await _skillsService.GetAllSkill();
            if (skills == null) {
                return NotFound();
           
            }
            return Ok(skills);

        }
        [HttpGet("id")]

        public IActionResult Skill(int id)
        {
            var skill = _skillsService.GetSkillById(id);
            if (skill == null)
            {
                return NotFound();
            }
            return Ok(skill);
        }
    }
}
