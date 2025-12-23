using BusinessLogic.DTOs;
using BusinessLogic.DTOs.Report;
using BusinessLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly ReportsService _reportsService;

        public ReportsController(ReportsService reportsService)
        {
            _reportsService = reportsService;
        }

        [HttpGet]
        public async Task<IActionResult> Reports()
        {
            var result = await _reportsService.GetAllReports();
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Report(int id)
        {
            var result = _reportsService.GetReportById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddReport(AddReportDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var id = await _reportsService.AddReport(dto);
            return Ok(new { id, message = "Report submitted successfully" });
        }

        [HttpPut("{id}/resolve")]
        public async Task<IActionResult> ResolveReport(int id)
        {
            await _reportsService.ResolveReport(id);
            return Ok("Report resolved successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            await _reportsService.DeleteReport(id);
            return Ok("Report deleted successfully");
        }
    }
}

