using Microsoft.AspNetCore.Mvc;
using time_tracking.Models;
using time_tracking.Service.IService;

namespace time_tracking.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TasksController : Controller
    {
        private readonly IServiceTasks _serviceTasks;

        public TasksController(IServiceTasks serviceTasks)
        {
            _serviceTasks = serviceTasks;
        }

        [HttpGet("{projectId}")]
        public async Task<IActionResult> GetAllFromProject(Guid projectId)
        {
            var result = await _serviceTasks.GetAllFromProjectAsync(projectId);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {

            var result = await _serviceTasks.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tasks tasks)
        {
            await _serviceTasks.CreateAsync(tasks);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Tasks tasks)
        {
            await _serviceTasks.UpdateAsync(tasks);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _serviceTasks.DeleteAsync(id);
            return Ok();
        }
    }
}
