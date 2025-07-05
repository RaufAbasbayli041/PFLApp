using Microsoft.AspNetCore.Mvc;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;

namespace PFLApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StadionsController : ControllerBase
    {
        private readonly IStadionService _service;

        public StadionsController(IStadionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);

            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StadionDto dto)
        {
            var created = await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StadionDto dto)
        {
            if (dto == null || dto.Id <= 0)
            {
                return BadRequest("Invalid stadion data.");
            }
            var updated = await _service.UpdateAsync(dto);
            if (updated == null)
            {
                return NotFound();
            }

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted ? Ok() : NotFound();
        }
    }
}
