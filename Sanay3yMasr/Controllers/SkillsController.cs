using System.Threading.Tasks;
using BusinessLogic.DTOs;
using BusinessLogic.Service;
using DataAccess.Models;
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
        [HttpPost]
        public async Task<IActionResult> AddSkill(AddSkillDTO dto)
        {
            if(!ModelState.IsValid) return BadRequest();
            var newSkill = await _skillsService.AddSkill(dto);
            return Ok(new { id = _skillsService.AddSkill(dto), message = "Skill added successfully" });

        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            await _skillsService.DeleteSkill(id);
            return Ok("Skill is Deleted");
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateSkill(int id , UpdateSkillAllDTO dto)
        {
            if(!ModelState.IsValid) return BadRequest();
            await _skillsService.UpdateSkill(id, dto);
            return Ok("Skill is updated");
        }

    }
}
