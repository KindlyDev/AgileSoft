using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserTask
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public TaskStatus Status { get; protected set; }

        private UserTask(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public UserTask Create(int id, string name, string description)
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
