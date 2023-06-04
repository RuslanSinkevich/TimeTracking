using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_tracking.Models
{
    public class TasksComments
    {
        [Key] public Guid Id { get; set; }
        public Guid TasksId { get; set; }
        [ForeignKey("TasksId")] public Tasks? Tasks { get; set; }
        public byte CommentType { get; set; }
        [NotMapped]
        public byte[]? Content { get; set; }
    }
}