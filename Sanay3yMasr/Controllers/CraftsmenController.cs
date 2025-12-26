using BusinessLogic.DTOs.Craftsmen;
using BusinessLogic.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [ApiController]
    [Route("api/craftsmen")]
    //[Authorize] // 🔒 أي حد يدخل لازم يكون عامل Login
    public class CraftsmenController : ControllerBase
    {
        private readonly ICraftsmanService _service;

        public CraftsmenController(ICraftsmanService service)
        {
            _service = service;
        }

        // =======================
        // GET ALL (Public / Logged Users)
        // =======================
        [HttpGet]
        [AllowAnonymous] // 👀 متاح للكل
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // =======================
        // GET BY ID (Public)
        // =======================
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // =======================
        // CREATE (Craftsman فقط)
        // =======================
        [HttpPost]
        //[Authorize(Roles = "Craftsman")]
        public async Task<IActionResult> Create([FromBody] CreateCraftsmanDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }

        // =======================
        // UPDATE (Craftsman فقط)
        // =======================
        [HttpPut("{id}")]
        //[Authorize(Roles = "Craftsman")]
        public async Task<IActionResult> Update(int id, UpdateCraftsmanDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.UpdateAsync(id, dto);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // =======================
        // DELETE (Admin فقط)
        // =======================
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return result.Success ? Ok(result) : NotFound(result);
        }
    }
}
