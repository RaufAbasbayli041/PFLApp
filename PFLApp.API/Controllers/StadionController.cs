using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.DAL.Entity;

namespace PFLApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var stadium = await _service.GetByIdAsync(id);
            return stadium == null ? NotFound() : Ok(stadium);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StadionDto dto)
        {
            var created = await _service.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }

}
