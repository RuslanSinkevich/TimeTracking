using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Models;
using time_tracking.Service.IService;

namespace time_tracking.Service
{
    public class ServiceTasksComments : IServiceTasksComments
    {
        private readonly ITasksCommentsRepository _tasksComRep;

        public ServiceTasksComments(ITasksCommentsRepository tasksComRep)
        {
            _tasksComRep = tasksComRep;
        }

        public async Task<TasksComments> GetAsync(Guid tasksCommentsId)
        {
            var tasksComments = await _tasksComRep.GetAsync(tasksCommentsId);
            return tasksComments;
        }

        public async Task<List<TasksComments>> GetAllFromTasksAsync(Guid tasksId)
        {
            var tasksCommentsList = await _tasksComRep.GetAllFromTasksAsync(tasksId);
            return tasksCommentsList;
        }

        public async Task CreateAsync(TasksComments tasksComments)
        {
            await _tasksComRep.CreateAsync(tasksComments);
        }

        public async Task UpdateAsync(TasksComments tasksComments)
        {
            var entity = await _tasksComRep.GetAsync(tasksComments.Id);
            entity.CommentType = tasksComments.CommentType;
            entity.Content = tasksComments.Content;
            await _tasksComRep.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid tasksCommentsId)
        {
            await _tasksComRep.DeleteAsync(tasksCommentsId);
        }

  

    }
}
