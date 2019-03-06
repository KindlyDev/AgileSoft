using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public class UserTask
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        UserTask[] UserTasks = new UserTask[]
        {
            new UserTask { Id = 1, Name = "UserTask1", Description = "Description1"},
            new UserTask { Id = 2, Name = "UserTask2", Description = "Description2"},
            new UserTask { Id = 3, Name = "UserTask3", Description = "Description3"},
            new UserTask { Id = 4, Name = "UserTask4", Description = "Description4"},
            new UserTask { Id = 5, Name = "UserTask5", Description = "Description5"},
            new UserTask { Id = 6, Name = "UserTask6", Description = "Description6"},
            new UserTask { Id = 7, Name = "UserTask7", Description = "Description7"},
            new UserTask { Id = 8, Name = "UserTask8", Description = "Description8"},
            new UserTask { Id = 9, Name = "UserTask9", Description = "Description9"},
            new UserTask { Id = 10, Name = "UserTask10", Description = "Description10"},
            new UserTask { Id = 11, Name = "UserTask11", Description = "Description11"},
            new UserTask { Id = 12, Name = "UserTask12", Description = "Description12"},
            new UserTask { Id = 13, Name = "UserTask13", Description = "Description13"},
            new UserTask { Id = 14, Name = "UserTask14", Description = "Description14"},
            new UserTask { Id = 15, Name = "UserTask15", Description = "Description15"},
        };
        

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UserTask>> Get()
        {
            return UserTasks;
        }

        // GET api/values/5
        [HttpGet("{Id}")]
        public ActionResult<UserTask> Get(int Id)
        {
            var UserTask = UserTasks.FirstOrDefault((task) => task.Id == Id);
            if (UserTask == null)
            {
                return NotFound();
            }
            return Ok(UserTask);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
