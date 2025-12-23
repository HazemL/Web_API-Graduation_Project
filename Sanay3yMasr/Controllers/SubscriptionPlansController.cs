using BusinessLogic.DTOs;
using BusinessLogic.DTOs.SubscriptionPlan;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionPlansController : ControllerBase
    {
        private readonly SubscriptionPlansService _service;

        public SubscriptionPlansController(SubscriptionPlansService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Plans()
        {
            return Ok(await _service.GetAllPlans());
        }

        [HttpGet("{id}")]
        public IActionResult Plan(int id)
        {
            var result = _service.GetPlanById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlan(AddSubscriptionPlanDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var id = await _service.AddPlan(dto);
            return Ok(new { id, message = "Subscription plan added successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlan(int id, UpdateSubscriptionPlanDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _service.UpdatePlan(id, dto);
            return Ok("Subscription plan updated successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlan(int id)
        {
            await _service.DeletePlan(id);
            return Ok("Subscription plan deleted successfully");
        }
    }
}
