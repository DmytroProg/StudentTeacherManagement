﻿using Microsoft.EntityFrameworkCore;
using StudentTeacherManagement.Core.Models;

namespace StudentTeaherManagement.Storage;

public class DataContext : DbContext
{
    public DataContext()
    {
        
    }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentTeacherDB;Integrated Security=True;")
            .UseLazyLoadingProxies()
            .EnableSensitiveDataLogging();
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
}