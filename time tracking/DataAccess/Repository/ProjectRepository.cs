using Microsoft.EntityFrameworkCore;
using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Models;

namespace time_tracking.DataAccess.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            var project = await _context.Project!.ToListAsync();
            return project;
        }

        public async Task<Project> GetAsync(Guid projectId)
        {
            var project = await _context.Project!.FirstOrDefaultAsync(project => project.Id == projectId);
            if (project == null) throw new Exception($"class=(Project) method=(GetAsync) - id: ({projectId}) not found");
            return project;
        }

        public async Task CreateAsync(Project project)
        {
            await _context.Project!.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Project project)
        {
            _context.Update(project);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid projectId)
        {
            var project = await _context.Project!.FirstOrDefaultAsync(project => project.Id == projectId);
            if (project == null) throw new Exception($"class=(Project) method=(DeleteAsync) - id: ({ projectId }) not found");
            _context.Remove(project);
            await _context.SaveChangesAsync();
        }

    }
}
