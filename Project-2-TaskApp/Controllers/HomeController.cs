using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project_2_TaskApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2_TaskApp.Controllers
{
    public class HomeController : Controller
    {

        private TaskContext newContext { get; set; }

        public HomeController(TaskContext newTask)
        {
            newContext = newTask;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEditTask()
        {
            ViewBag.Categorys = newContext.Categorys.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult AddEditTask(TaskData ar)
        {
            if (ModelState.IsValid)
            {
                newContext.Update(ar);
                newContext.SaveChanges();

                return RedirectToAction("Quadrants");
            }
            else
            {
                ViewBag.Categorys = newContext.Categorys.ToList();
                return View(ar);
            }
        }

        public IActionResult Quadrants()
        {
            var tasks = newContext.Tasks.Include(x => x.category).Where(x => x.completed == false).ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Edit(int taskid)
        {
            ViewBag.Categorys = newContext.Categorys.ToList();

            var task = newContext.Tasks.Single(x => x.taskId == taskid);

            return View("AddEditTask", task);
        }
        [HttpPost]
        public IActionResult Edit(TaskData blah)
        {
            newContext.Update(blah);
            newContext.SaveChanges();

            return RedirectToAction("AddEditTask");
        }


        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            var task = newContext.Tasks.Single(x => x.taskId == taskid);


            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(TaskData ar)
        {
            newContext.Tasks.Remove(ar);
            newContext.SaveChanges();
            return RedirectToAction("AddEditTask");
        }

    }
}
