using Microsoft.AspNetCore.Mvc;
using System;
using time_tracking.Models;
using time_tracking.Service.IService;

namespace time_tracking.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProjectController : Controller
    {
        private readonly IServiceProject _serviceProject;

        public ProjectController(IServiceProject serviceProject)
        {
            _serviceProject = serviceProject;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {

            var result = await _serviceProject.GetAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _serviceProject.GetAllAsync();
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {

            await _serviceProject.CreateAsync(project);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Project project)
        {
            await _serviceProject.UpdateAsync(project);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _serviceProject.DeleteAsync(id);
            return Ok();
        }
    }
}
