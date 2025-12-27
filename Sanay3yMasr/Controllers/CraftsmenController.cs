using BusinessLogic.DTOs.Craftsmen;
using BusinessLogic.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Constants;

namespace Sanay3yMasr.Controllers
{
    [ApiController]
    [Route("api/craftsmen")]

    // 🔒 الافتراضي: أي Endpoint محتاج Login
    [Authorize]
    public class CraftsmenController : ControllerBase
    {
        private readonly ICraftsmanService _service;

        public CraftsmenController(ICraftsmanService service)
        {
            _service = service;
        }

        // =====================================================
        // GET ALL Craftsmen
        // Public (مش محتاج Login)
        // =====================================================
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // =====================================================
        // GET Craftsman By Id
        // Public
        // =====================================================
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // =====================================================
        // CREATE Craftsman Profile
        // Only Craftsman Role
        // =====================================================
        [HttpPost]
        [Authorize(Roles = Roles.Craftsman)]
        public async Task<IActionResult> Create([FromBody] CreateCraftsmanDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }

        // =====================================================
        // UPDATE Craftsman Profile
        // Only Craftsman Role
        // =====================================================
        [HttpPut("{id}")]
        [Authorize(Roles = Roles.Craftsman)]
        public async Task<IActionResult> Update(int id, UpdateCraftsmanDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.UpdateAsync(id, dto);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // =====================================================
        // DELETE Craftsman Profile
        // Admin Only
        // =====================================================
        [HttpDelete("{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return result.Success ? Ok(result) : NotFound(result);
        }
    }
}
