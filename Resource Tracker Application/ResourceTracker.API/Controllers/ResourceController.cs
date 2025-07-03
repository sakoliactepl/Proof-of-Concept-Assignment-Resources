using Microsoft.AspNetCore.Mvc;
using ResourceTracker.API.Models;
using ResourceTracker.API.Services;

namespace ResourceTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResourceController : ControllerBase
    {
        private readonly IResourceService _service;

        public ResourceController(IResourceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllResourcesAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var res = await _service.GetResourceByIdAsync(id);
            return res == null ? NotFound() : Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Resource resource)
        {
            await _service.AddResourceAsync(resource);
            return CreatedAtAction(nameof(GetById), new { id = resource.EmpId }, resource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Resource resource)
        {
            if (id != resource.EmpId) return BadRequest("ID mismatch");
            await _service.UpdateResourceAsync(resource);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteResourceAsync(id);
            return NoContent();
        }
    }
}
