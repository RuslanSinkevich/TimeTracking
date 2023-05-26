using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Models;
using time_tracking.Service.IService;

namespace time_tracking.Service
{
    public class ServiceTasks : IServiceTasks
    {
        private readonly ITasksRepository _tasksRepository;

        public ServiceTasks(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public async Task<Tasks> GetAsync(Guid tasksId)
        {
            var tasks = await _tasksRepository.GetAsync(tasksId);
            return tasks;
        }

        public async Task<List<Tasks>> GetAllFromProjectAsync(Guid projectId)
        {
            var tasksList = await _tasksRepository.GetAllFromProjectAsync(projectId);
            return tasksList;
        }

        public async Task CreateAsync(Tasks tasks)
        {
            await _tasksRepository.CreateAsync(tasks);
        }

        public async Task UpdateAsync(Tasks tasks)
        {
            var entity = await _tasksRepository.GetAsync(tasks.Id);
            entity.TasksName = tasks.TasksName;
            entity.UpdateDate = new DateTime();
            await _tasksRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid tasksId)
        {
            await _tasksRepository.DeleteAsync(tasksId);
        }

  

    }
}
