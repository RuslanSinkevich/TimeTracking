using Microsoft.AspNetCore.Mvc;
using time_tracking.Models;
using time_tracking.Service.IService;

namespace time_tracking.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TasksCommentsController : Controller
    {
        private readonly IServiceTasksComments _serviceTasksCom;

        public TasksCommentsController(IServiceTasksComments serviceTasksCom)
        {
            _serviceTasksCom = serviceTasksCom;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllFromTasks(Guid id)
        {
            var result = await _serviceTasksCom.GetAllFromTasksAsync(id);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {

            var result = await _serviceTasksCom.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TasksComments taskComments)
        {

            await _serviceTasksCom.CreateAsync(taskComments);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(TasksComments taskComments)
        {
            await _serviceTasksCom.UpdateAsync(taskComments);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _serviceTasksCom.DeleteAsync(id);
            return Ok();
        }
    }
}
