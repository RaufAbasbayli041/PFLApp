using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;

namespace PFLApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ControllerBase
    {
        private readonly IMatchService _service;

        public MatchesController(IMatchService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatch([FromBody] MatchDto dto)
        {
            try
            {
                var result = await _service.AddMatchAsync(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
