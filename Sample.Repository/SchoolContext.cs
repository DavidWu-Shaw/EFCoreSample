using Microsoft.EntityFrameworkCore;
using Sample.Data;
using System;

namespace Sample.Repository
{
    public class SchoolContext : DbContext
    {
        private string _connectionString; 

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public SchoolContext()
        {
            _connectionString = @"Server=(local);Database=Sample;Trusted_Connection=True;";
        }

        public SchoolContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
