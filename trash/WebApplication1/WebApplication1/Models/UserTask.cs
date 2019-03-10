using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserTask
    {
        public long TaskId { get; protected set; }
        public string TaskName { get; protected set; }
        public bool TaskDescription { get; protected set; }
        public TaskStatus Status { get; protected set; }

        private UserTask(long id, string name, bool description)
        {
            TaskId = id;
            TaskName = name;
            TaskDescription = description;
        }

        public UserTask Create(long id, string name, bool description)
        {
            // some validation rules
            return new UserTask(id, name, description);
        }

        public void MoveTask(TaskStatus newStatus)
        {
            Status = newStatus;
        }
    }
}
