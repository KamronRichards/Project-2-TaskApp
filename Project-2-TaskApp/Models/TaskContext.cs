using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2_TaskApp.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            //blank
        }

        public DbSet<TaskData> Tasks { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)

        {
            // this is where I seed the database

            mb.Entity<TaskData>().HasData(

                    new TaskData
                    {
                        taskId = 1,
                        taskName = "Homework",
                        dueDate = DateTime.Today,
                        quadrant = "Urgent, Important",
                        category = "School",
                        completed = false
                    },
                    new TaskData
                    {
                        taskId = 2,
                        taskName = "Job Stuff",
                        dueDate = DateTime.Today,
                        quadrant = "Not Urgent, Important",
                        category = "Work",
                        completed = true
                    }
                    
                );
        }
    }
}
