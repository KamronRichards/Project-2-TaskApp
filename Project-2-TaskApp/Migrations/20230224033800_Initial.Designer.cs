﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_2_TaskApp.Models;

namespace Project_2_TaskApp.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20230224033800_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Project_2_TaskApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Project_2_TaskApp.Models.TaskData", b =>
                {
                    b.Property<int>("taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dueDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("quadrant")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("taskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("taskId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            taskId = 1,
                            CategoryID = 1,
                            completed = false,
                            dueDate = new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            quadrant = 2,
                            taskName = "Homework"
                        },
                        new
                        {
                            taskId = 2,
                            CategoryID = 2,
                            completed = true,
                            dueDate = new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            quadrant = 3,
                            taskName = "Job Stuff"
                        });
                });

            modelBuilder.Entity("Project_2_TaskApp.Models.TaskData", b =>
                {
                    b.HasOne("Project_2_TaskApp.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
