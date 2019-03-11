using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IUserTaskRepository
    {
        IEnumerable<UserTask> GetAllTasks();
        UserTask GetTaskById(int id);
        //void Create(UserTask item);
        //void Update(UserTask item); 
        //void Delete(long id); 
        //void Save();
    }
}
