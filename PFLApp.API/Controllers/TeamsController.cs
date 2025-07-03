using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.DAL.Entity;

namespace PFLApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _service;

        public TeamsController(ITeamService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var team = await _service.GetByIdAsync(id);
            return team == null ? NotFound() : Ok(team);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TeamDto dto)
        {
            var created = await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _service.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TeamDto dto)
        {
            if (dto is null )
            {
                return BadRequest("Team data is null.");
            }
             
            var updated = await _service.UpdateAsync(dto);
            if (updated == null)
            {
                return NotFound($"Team with ID {dto.Id} not found.");
            }
            return Ok(updated);


        }
    }
}
