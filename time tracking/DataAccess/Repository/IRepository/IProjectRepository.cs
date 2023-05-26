using time_tracking.Models;

namespace time_tracking.DataAccess.Repository.IRepository
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetAsync(Guid projectId);
        Task CreateAsync(Project project);
        Task UpdateAsync(Project project);
        Task DeleteAsync(Guid projectId);
    }
}
