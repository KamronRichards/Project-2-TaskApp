using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2_TaskApp.Models
{
    public class TaskData
    {
        [Required]
        public string taskName { get; set; }
        public DateTime dueDate { get; set; }
        [Required]
        public int quadrant { get; set; }
        public string category { get; set; }
        public bool completed { get; set; }
    }
}
