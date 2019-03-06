using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDev.Models
{
    public static class SampleTask
    {
        public static void Initialize(TaskContext context)
        {
            if (!context.UserTasks.Any())
            {
                context.UserTasks.AddRange(
                    new UserTask
                    {
                        Id = 1,
                        Name = "t1",
                        Description = "d1"
                    },
                    new UserTask
                    {
                        Id = 2,
                        Name = "t2",
                        Description = "d3"
                    },
                    new UserTask
                    {
                        Id = 3,
                        Name = "t3",
                        Description = "d3"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
