using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2_TaskApp.Models
{
    public class TaskData
    {
        [Key][Required]
        public int taskId { get; set; }
        [Required]
        public string taskName { get; set; }
        public DateTime dueDate { get; set; }
        [Required]
        public int? quadrant { get; set; }
        public bool completed { get; set; }

        //Build Forgein Key relationship
        public int CategoryID { get; set; }
        public Category category { get; set; }

    }
}
