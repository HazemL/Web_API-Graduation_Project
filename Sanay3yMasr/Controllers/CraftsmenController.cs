using System.Threading.Tasks;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftsmenController : ControllerBase
    {
        CraftsmanService _craftsmanService;
        public CraftsmenController(CraftsmanService craftsmanService)
        {
            _craftsmanService = craftsmanService;
        }
        [HttpGet]
        public async Task<IActionResult> Craftsmen() {
            var Craftsmen =await _craftsmanService.GetAllCraftsmen();
            if (Craftsmen == null)
            {
                return NoContent();
            }
            return Ok(Craftsmen);
        }
        [HttpGet("id")]
        public async Task<IActionResult> Craftsman(int id) {
            var Craftsman =await _craftsmanService.GetByIdCraftsman(id);
            if(Craftsman == null)
            {
                return NoContent();
            }
            return Ok(Craftsman);
        }
   
    }
}
