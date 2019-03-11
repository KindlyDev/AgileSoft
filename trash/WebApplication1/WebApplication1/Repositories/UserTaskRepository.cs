using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace WebApplication1.Repositories
{
    // dbcontext

    public class UserTaskRepository : IUserTaskRepository
    {
        private string _connectionString;
        // constr; context;
        public UserTaskRepository(string connectionString)
        {
            _connectionString = connectionString; 
        }

        public IEnumerable<UserTask> GetAllTasks()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = connection.Query<UserTask>("SELECT Id, Name, Description FROM  UserTask");
                return result;
            }
            //return db.UserTasks.ToList();
            //throw new NotImplementedException();
        }

        public UserTask GetTaskById(int id)
        {
            //return db.UserTasks.Find(id);
            throw new NotImplementedException();
        }
    }
}