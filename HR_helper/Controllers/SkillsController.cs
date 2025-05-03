using HR_helper.Models;
using HR_helper.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using static HR_helper.Models.SkillsSet;

namespace HR_helper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillsController : ControllerBase
    {
        private readonly IMLService _mlService;

        public SkillsController(IMLService mlService)
        {
            _mlService = mlService;
        }

        [HttpPost("analyze")]
        public async Task<IActionResult> AnalyzeSkills([FromBody] SkillsForAnalyse request)
        {
            try
            {
                var result = await _mlService.AnalyzeSkillsAsync(request.Skills);
                return Ok(new { response = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ошибка: {ex.Message}");
            }
        }
    }
}
