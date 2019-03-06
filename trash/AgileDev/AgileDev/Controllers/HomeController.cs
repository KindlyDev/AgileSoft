using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgileDev.Models;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDev.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db;
        public HomeController(TaskContext context)
        {
            db = context;
        }
        /*
        public IActionResult Index()
        {
            return View(db.UserTasks.ToList());
        }
        */
        public async Task<IActionResult> Index(int page=1)
        {
            int pageSize = 5;

            IQueryable<UserTask> sourse = db.UserTasks;
            var count = await sourse.CountAsync();
            var items = await sourse.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                UserTasks = items
            };
            return View(viewModel);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            //return View(db.UserTasks.Where(Id == id).ToList());
            var UserTask = db.UserTasks.FirstOrDefault((task) => task.Id == id);
            if (UserTask == null)
            {
                return NotFound();
            }
            return Ok(UserTask);
        }
    }
}