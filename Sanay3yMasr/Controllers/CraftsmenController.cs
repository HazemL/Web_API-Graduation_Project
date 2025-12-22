using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Service;
using BusinessLogic.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftsmenController : ControllerBase
    {
        CraftsmanService _craftsmanService;
        IMapper _mapper;
        public CraftsmenController(CraftsmanService craftsmanService,IMapper mapper)
        {
            _craftsmanService = craftsmanService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Craftsmen() {
            var Craftsmen = await _craftsmanService.GetAllCraftsmen();
            if (Craftsmen == null)
            {
                return NoContent();
            }
            return Ok(Craftsmen);
        }
        [HttpGet("id")]
        public async Task<IActionResult> Craftsman(int id) {
            var Craftsman = await _craftsmanService.GetByIdCraftsman(id);
            if (Craftsman == null)
            {
                return NoContent();
            }
            return Ok(Craftsman);
        }
       
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraftsman(int id)
        {
            _craftsmanService?.DeleteCraftsman(id);
            return Ok(new { message = "Craftsman deleted successfully (Soft Delete)." });
        }
        [HttpPut("id")]
        public async Task<IActionResult> update(int id, UpdateCraftsmanAllDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (dto == null) throw new Exception("Not valid");
            if (id <= 0) throw new Exception("Id not valid");
            await _craftsmanService.UpdateCraftsman(id, dto);
            return Ok(new {message = "Craftsman is updated."});
        }
        //add
        [HttpPost]
        public async Task<IActionResult> AddCraftsman(AddCraftsmanViewModel vm)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            var craftsman = _mapper.Map<AddCraftsmanDTO>(vm);
            if (craftsman == null) throw new Exception("Craftsman not found");
            await _craftsmanService.AddCraftsman(craftsman);
            return Ok(vm);
              
        }
    }
}
