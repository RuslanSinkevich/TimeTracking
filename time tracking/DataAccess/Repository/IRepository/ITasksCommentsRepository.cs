using time_tracking.Models;

namespace time_tracking.DataAccess.Repository.IRepository
{
    public interface ITasksCommentsRepository
    {
        Task<List<TasksComments>> GetAllFromTasksAsync(Guid tasksId);
        Task<TasksComments> GetAsync(Guid tasksCommentsId);
        Task CreateAsync(TasksComments tasksComments);
        Task UpdateAsync(TasksComments tasksComments);
        Task DeleteAsync(Guid tasksCommentsId);
    }
}
