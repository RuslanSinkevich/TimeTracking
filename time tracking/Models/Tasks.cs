using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_tracking.Models
{
    public class Tasks
    {
        [Key]
        public Guid Id { get; set; }
        public string? TasksName { get; set; }
        public Guid ProjectId { get; set; }
        [ForeignKey("ProjectId")] public Project? Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CancelDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
