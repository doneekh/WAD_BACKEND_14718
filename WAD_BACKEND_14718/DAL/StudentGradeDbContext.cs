﻿using Microsoft.EntityFrameworkCore;
using CW_WAD_00014718.Models;

namespace WAD_BACKEND_14718.DAL
{
    public class StudentGradeDbContext : DbContext
    {
        public DbSet<Student>? Student { get; set; }
        public DbSet<Grade>? Grade { get; set; }

        public StudentGradeDbContext(DbContextOptions<StudentGradeDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>()
            //    .HasOne(e => e.Category);

        }
    }
}
