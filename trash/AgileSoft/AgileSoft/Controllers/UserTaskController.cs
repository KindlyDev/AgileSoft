using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AgileSoft.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgileSoft.Controllers
{
    [Route("api/[controller]")]
    public class UserTaskController : Controller
    {
        TaskContext db;
        public UserTaskController(TaskContext context)
        {
            this.db = context;
            if (!db.UserTasks.Any())
            {
                db.UserTasks.Add(new UserTask { Id = 1, Name = "t1", Description = "d1" });
                db.UserTasks.Add(new UserTask { Id = 2, Name = "t2", Description = "d2" });
                db.UserTasks.Add(new UserTask { Id = 3, Name = "t3", Description = "d3" });
                db.SaveChanges();
            }
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<UserTask> Get()
        {
            return db.UserTasks.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            UserTask userTask = db.UserTasks.FirstOrDefault(x => x.Id == id);
            if (userTask == null)
                return NotFound();
            return new ObjectResult(userTask);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
