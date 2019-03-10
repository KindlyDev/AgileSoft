using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IUserTaskRepository
    {
        Task<IEnumerable<UserTask>> GetAllTasks();
        Task<UserTask> GetTaskById(long id);
    }
}
