using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class UserTaskContext : DbContext
    {
        public UserTaskContext(DbContextOptions<UserTaskContext> options)
            : base(options)
        {
        }
        public DbSet<UserTask> UserTasks { get; set; }


    }
}
