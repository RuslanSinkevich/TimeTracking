using time_tracking.Models;
using time_tracking.Models.ViewModel;

namespace time_tracking.DataAccess.Repository.IRepository
{
    public interface ITasksRepository
    {
        Task<List<Tasks>> GetAllFromProjectAsync(Guid projectId);
        Task<Tasks> GetAsync(Guid tasksId);
        Task CreateAsync(Tasks tasks);
        Task UpdateAsync(Tasks tasks);
        Task DeleteAsync(Guid tasksId);
    }
}
