using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Models;
using time_tracking.Service.IService;

namespace time_tracking.Service
{
    public class ServiceProject : IServiceProject
    {
        private readonly IProjectRepository _projectRepository;

        public ServiceProject(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Project> GetAsync(Guid projectId)
        {
            var project = await _projectRepository.GetAsync(projectId);
            return project;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            var projectList = await _projectRepository.GetAllAsync();
            return projectList;
        }

        public async Task CreateAsync(Project project)
        {
            await _projectRepository.CreateAsync(project);
        }

        public async Task UpdateAsync(Project project)
        {
            var entity = await _projectRepository.GetAsync(project.Id);
            entity.ProjectName = project.ProjectName;
            entity.UpdateDate = new DateTime();
            await _projectRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid projectId)
        {
            await _projectRepository.DeleteAsync(projectId);
        }

  

    }
}
