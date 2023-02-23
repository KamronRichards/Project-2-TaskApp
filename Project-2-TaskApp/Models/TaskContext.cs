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
        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)

        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home" },
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
                );

            // this is where I seed the database

            mb.Entity<TaskData>().HasData(

                    new TaskData
                    {
                        taskId = 1,
                        taskName = "Homework",
                        dueDate = DateTime.Today,
                        quadrant = "Urgent, Important",
                        CategoryID = 1,
                        completed = false
                    },
                    new TaskData
                    {
                        taskId = 2,
                        taskName = "Job Stuff",
                        dueDate = DateTime.Today,
                        quadrant = "Not Urgent, Important",
                        CategoryID = 2,
                        completed = true
                    }
                    
                );
        }
    }
}
