using Microsoft.EntityFrameworkCore;
using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Models;

namespace time_tracking.DataAccess.Repository
{
    public class TasksCommentsRepository : ITasksCommentsRepository
    {
        private readonly ApplicationDbContext _context;

        public TasksCommentsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TasksComments>> GetAllFromTasksAsync(Guid taskId)
        {
            var tasksComList = await _context.TasksComments!.Where(tasksComList => tasksComList.TasksId == taskId).ToListAsync();
            if (tasksComList == null) throw new Exception($"class=(tasksComments) method=(GetAllFromTaskAsync) - id: ({taskId}) not found");
            return tasksComList;
        }

        public async Task<TasksComments> GetAsync(Guid tasksCommentsId)
        {
            var tasksComList = await _context.TasksComments!.FirstOrDefaultAsync(tasksComList => tasksComList.Id == tasksCommentsId);
            if (tasksComList == null) throw new Exception($"class=(tasksComments) method=(GetAsync) - id: ({tasksComList}) not found");
            return tasksComList;
        }

        public async Task CreateAsync(TasksComments tasksComList)
        {
            await _context.TasksComments!.AddAsync(tasksComList);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TasksComments tasksComList)
        {
            _context.Update(tasksComList);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid tasksCommentsId)
        {
            var tasksComList = await _context.TasksComments!.FirstOrDefaultAsync(tasksComList => tasksComList.Id == tasksCommentsId);
            if (tasksComList == null) throw new Exception($"class=(tasksComments) method=(DeleteAsync) - id: ({ tasksCommentsId }) not found");
            _context.Remove(tasksComList);
            await _context.SaveChangesAsync();
        }

    }
}
