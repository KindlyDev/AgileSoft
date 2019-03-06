using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgileDev.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base()
        {
        }
        public DbSet<UserTask> UserTasks { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
