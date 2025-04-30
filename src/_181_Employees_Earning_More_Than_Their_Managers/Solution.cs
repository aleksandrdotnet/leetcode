using Microsoft.EntityFrameworkCore;

namespace _181_Employees_Earning_More_Than_Their_Managers;

public class Solution
{
    public class AppDbContext : DbContext
    {
        // ReSharper disable once MemberHidesStaticFromOuterClass
        public DbSet<Employee> Employee { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsRequired();

                entity.HasData(
                    new Employee { Id = 1, Name = "Joe", Salary = 70000, ManagerId = 3 },
                    new Employee { Id = 2, Name = "Henry", Salary = 80000, ManagerId = 4 },
                    new Employee { Id = 3, Name = "Sam", Salary = 60000, ManagerId = null },
                    new Employee { Id = 4, Name = "Max", Salary = 90000, ManagerId = null }
                );
            });
        }
    }

    public class Employee
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public int Salary { get; init; }
        public int? ManagerId { get; init; }
    }
}