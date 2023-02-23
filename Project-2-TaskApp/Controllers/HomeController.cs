using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;

        private TaskContext newContext { get; set; }

        public HomeController(ILogger<HomeController> logger, TaskContext newTask)
        {
            _logger = logger;
            newContext = newTask;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEditTask ()
        {
            return View();
        }

        public IActionResult Quadrants()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
