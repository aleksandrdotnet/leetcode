using Microsoft.EntityFrameworkCore;

namespace _1075_Project_Employees_I;

public class Solution
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasKey(o => new { o.ProjectId, o.EmployeeId });
            modelBuilder.Entity<Employee>().HasKey(o => new { o.EmployeeId, o.ExperienceYears });

            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 1, EmployeeId = 1 },
                new Project { ProjectId = 1, EmployeeId = 2 },
                new Project { ProjectId = 1, EmployeeId = 3 },
                new Project { ProjectId = 2, EmployeeId = 1 },
                new Project { ProjectId = 2, EmployeeId = 4 }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Name = "Khaled", ExperienceYears = 3 },
                new Employee { EmployeeId = 2, Name = "Ali", ExperienceYears = 2 },
                new Employee { EmployeeId = 3, Name = "John", ExperienceYears = 1 },
                new Employee { EmployeeId = 4, Name = "Doe", ExperienceYears = 2 }
            );
        }
    }
}