using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace _577_Employee_Bonus;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => e.EmpId);
            modelBuilder.Entity<Bonus>().HasKey(b => b.EmpId);

            // Добавляем данные
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 3, Name = "Brad", Supervisor = null, Salary = 4000 },
                new Employee { EmpId = 1, Name = "John", Supervisor = 3, Salary = 1000 },
                new Employee { EmpId = 2, Name = "Dan", Supervisor = 3, Salary = 2000 },
                new Employee { EmpId = 4, Name = "Thomas", Supervisor = 3, Salary = 4000 }
            );

            modelBuilder.Entity<Bonus>().HasData(
                new Bonus { EmpId = 2, BonusAmount = 500 },
                new Bonus { EmpId = 4, BonusAmount = 2000 }
            );
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }

        [StringLength(255)] public required string Name { get; set; }

        public int? Supervisor { get; set; }
        public int Salary { get; set; }
    }

    public class Bonus
    {
        public int EmpId { get; set; }
        public int? BonusAmount { get; set; }
    }
}