using Microsoft.EntityFrameworkCore;
using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Models;

namespace time_tracking.DataAccess.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly ApplicationDbContext _context;

        public TasksRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tasks>> GetAllFromProjectAsync(Guid projectId)
        {
            List<Tasks> tasksList;
            if (projectId == Guid.Empty)
            {
                tasksList = await _context.Tasks!
                    .Include(tasks => tasks.Project)
                    .ToListAsync();
            }
            else
            {
                 tasksList = await _context.Tasks!
                    .Where(tasks => tasks.ProjectId == projectId)
                    .Include(tasks => tasks.Project)
                    .ToListAsync();
            }

            if (tasksList == null)
                throw new Exception($"class=(Tasks) method=(GetAllFromProjectAsync) - id: ({projectId}) not found");
            return tasksList;
        }

        public async Task<Tasks> GetAsync(Guid tasksId)
        {
            var tasks = await _context.Tasks!.FirstOrDefaultAsync(tasks => tasks.Id == tasksId);
            if (tasks == null) throw new Exception($"class=(Tasks) method=(GetAsync) - id: ({tasksId}) not found");
            return tasks;
        }

        public async Task CreateAsync(Tasks tasks)
        {
            await _context.Tasks!.AddAsync(tasks);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tasks tasks)
        {
            _context.Update(tasks);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid tasksId)
        {
            var tasks = await _context.Tasks!.FirstOrDefaultAsync(tasks => tasks.Id == tasksId);
            if (tasks == null) throw new Exception($"class=(Tasks) method=(DeleteAsync) - id: ({ tasksId }) not found");
            _context.Remove(tasks);
            await _context.SaveChangesAsync();
        }

    }
}
