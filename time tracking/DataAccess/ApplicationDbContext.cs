using Microsoft.EntityFrameworkCore;
using time_tracking.Models;

namespace time_tracking.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Project>? Project { get; set; }
        public DbSet<Tasks>? Tasks { get; set; }
        public DbSet<TasksComments>? TasksComments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var id3 = Guid.NewGuid();
            var id4 = Guid.NewGuid();
            modelBuilder.Entity<Project>().HasData(
                new Project[]
                {
                    new Project { 
                        Id = id1, 
                        ProjectName= "Проект 1", 
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now
                    },
                    new Project {
                        Id = id2,
                        ProjectName = "Проект 2",
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now
                    },
                    new Project {
                        Id = id3,
                        ProjectName = "Проект 3",
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now
                    },
                    new Project {
                        Id = id4,
                        ProjectName = "Проект 4",
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now
                    },
                });

            modelBuilder.Entity<Tasks>().HasData(
                new Tasks[]
                {
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName= "задача 1",
                        ProjectId = id1,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName = "задача 2",
                        ProjectId = id1,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName= "задача 1_2",
                        ProjectId = id2,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName = "задача 2_2",
                        ProjectId = id2,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName= "задача 1_3",
                        ProjectId = id3,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName = "задача 2_3",
                        ProjectId = id3,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName= "задача 1_4",
                        ProjectId = id4,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                    new Tasks {
                        Id = Guid.NewGuid(),
                        TasksName = "задача 2_4",
                        ProjectId = id4,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        CancelDate = DateTime.Now,
                        StartDate = DateTime.Now
                    },
                });
        }

    }
}
