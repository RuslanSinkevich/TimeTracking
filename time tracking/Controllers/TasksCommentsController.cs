using Microsoft.AspNetCore.Mvc;
using time_tracking.Models;
using time_tracking.Service.IService;
using Newtonsoft.Json.Linq;

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
        public async Task<IActionResult> Create()
        {
            var requestBody = await new StreamReader(Request.Body).ReadToEndAsync();

            var jsonObject = JObject.Parse(requestBody);

            var id = jsonObject["id"]!.ToString();
            var idGuid = Guid.Parse(id);

            var tasksId = jsonObject["tasksId"]!.ToString();
            var tasksIdGuid = Guid.Parse(tasksId);

            var commentType = jsonObject["commentType"]!.ToString();
            var commentTypeByte = byte.Parse(commentType);

            var content = jsonObject["content"]!.ToString();
            var contentBytes = Convert.FromBase64String(content);

            var taskComments = new TasksComments()
            {
                Id = idGuid,
                TasksId = tasksIdGuid,
                CommentType = commentTypeByte,
                Content = contentBytes
            };

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
