using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.DAL.Entity;

namespace PFLApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StadionsController : ControllerBase
    {
        private readonly IGenericService<Stadion, StadionDto> _service;

        public StadionsController(IGenericService<Stadion, StadionDto> service)
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] StadionDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
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
