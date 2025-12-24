using BusinessLogic.DTOs.Craftsmen;
using BusinessLogic.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [ApiController]
    [Route("api/craftsmen")]
    //[Authorize]
    public class CraftsmenController : ControllerBase
    {
        private readonly ICraftsmanService _service;

        public CraftsmenController(ICraftsmanService service)
        {
            _service = service;
        }

        // GET /api/craftsmen
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // GET /api/craftsmen/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        // POST /api/craftsmen
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCraftsmanDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var id = await _service.CreateAsync(dto);
            return Ok(new { id });
        }

        // PUT /api/craftsmen/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCraftsmanDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = await _service.UpdateAsync(id, dto);
            return updated ? Ok() : NotFound();
        }

        // DELETE /api/craftsmen/{id}
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted ? Ok() : NotFound();
        }
    }
}
