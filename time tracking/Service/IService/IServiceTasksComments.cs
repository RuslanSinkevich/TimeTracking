using time_tracking.Models;

namespace time_tracking.Service.IService
{
    public interface IServiceTasksComments
    {
        Task<TasksComments> GetAsync(Guid tasksCommentsId);
        Task<List<TasksComments>> GetAllFromTasksAsync(Guid tasksId);
        Task CreateAsync(TasksComments tasksComments);
        Task UpdateAsync(TasksComments tasksComments);
        Task DeleteAsync(Guid tasksCommentsId);
    }
}
