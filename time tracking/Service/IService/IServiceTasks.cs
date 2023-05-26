using time_tracking.Models;

namespace time_tracking.Service.IService
{
    public interface IServiceTasks
    {
        Task<Tasks> GetAsync(Guid tasksId);
        Task<List<Tasks>> GetAllFromProjectAsync(Guid projectId);
        Task CreateAsync(Tasks tasks);
        Task UpdateAsync(Tasks tasks);
        Task DeleteAsync(Guid tasksId);
    }
}
