using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserTask
    {
        public long TaskId { get; set; }
        public string TaskName { get; set; }
        public bool TaskDescription { get; set; }
    }
}
