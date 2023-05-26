using time_tracking.Models;

namespace time_tracking.Service.IService
{
    public interface IServiceProject
    {
        Task<Project> GetAsync(Guid projectId);
        Task<List<Project>> GetAllAsync();
        Task CreateAsync(Project project);
        Task UpdateAsync(Project project);
        Task DeleteAsync(Guid projectId);
    }
}
