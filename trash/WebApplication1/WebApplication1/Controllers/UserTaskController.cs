using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Dtos;
using WebApplication1.Models;
using WebApplication1.Repositories;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTaskController : ControllerBase
    {
        private IUserTaskRepository _repository;
        public UserTaskController(IUserTaskRepository repository)
        {
            _repository = repository;
        }


        // GET: api/UserTask
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<UserTask>>> GetUserTasks()
        public ActionResult<IEnumerable<UserTask>> GetUserTasks()
        {

            var tasks = _repository.GetAllTasks();

            // TODO: envelope
            return Ok(tasks);
        }

        // GET: api/UserTask/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<UserTask>> GetUserTask(long id)
        public ActionResult<UserTask> GetUserTask(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/UserTask/
        // TODO: swap return type to 201
        [HttpPost()]
        //public async Task<ActionResult<UserTask>> Create(UserTaskDto dto)
        public ActionResult<UserTask> Create(UserTaskDto dto)
        {
            throw new NotImplementedException();
        }
    }
}