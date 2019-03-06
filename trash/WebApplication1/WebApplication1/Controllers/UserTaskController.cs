using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTaskController : ControllerBase
    {
        private readonly UserTaskContext _context;

        public UserTaskController(UserTaskContext context)
        {
            _context = context;

            if (_context.UserTasks.Count() == 0)
            {
                // Create a new UserTask if collection is empty,
                // which means you can't delete all UserTasks.
                _context.UserTasks.Add(new UserTask { TaskName = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET: api/UserTask
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserTask>>> GetUserTasks()
        {
            return await _context.UserTasks.ToListAsync();
        }

        // GET: api/UserTask/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserTask>> GetUserTask(long id)
        {
            var UserTask = await _context.UserTasks.FindAsync(id);

            if (UserTask == null)
            {
                return NotFound();
            }

            return UserTask;
        }
    }
}