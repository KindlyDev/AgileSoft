using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class UserTaskRepository : IUserTaskRepository
    {
        // dbcontext

        // constr; context;
        public UserTaskRepository(string connectionString)
        {
            // create
        }

        public Task<IEnumerable<UserTask>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task<UserTask> GetTaskById(long id)
        {
            throw new NotImplementedException();
        }
    }
}