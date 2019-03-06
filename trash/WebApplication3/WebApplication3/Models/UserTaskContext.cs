using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class UserTaskContext : DbContext
    {
        public UserTaskContext()
        {
        }

        public UserTaskContext(DbContextOptions<UserTaskContext> options) 
            : base(options)
        {
        }

        public DbSet<UserTask> UserTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KindlyDev;Trusted_Connection=True;");
            }
        }
    }
}
