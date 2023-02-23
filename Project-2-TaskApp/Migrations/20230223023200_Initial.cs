using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2_TaskApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    taskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    taskName = table.Column<string>(nullable: false),
                    dueDate = table.Column<DateTime>(nullable: false),
                    quadrant = table.Column<string>(nullable: false),
                    category = table.Column<string>(nullable: true),
                    completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.taskId);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "taskId", "category", "completed", "dueDate", "quadrant", "taskName" },
                values: new object[] { 1, "School", false, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Urgent, Important", "Homework" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "taskId", "category", "completed", "dueDate", "quadrant", "taskName" },
                values: new object[] { 2, "Work", true, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Not Urgent, Important", "Job Stuff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
