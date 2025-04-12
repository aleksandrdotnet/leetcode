using Microsoft.EntityFrameworkCore;

namespace _185_Department_Top_Three_Salaries;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey("Id");
            modelBuilder.Entity<Department>().HasKey("Id");

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "Sales" }
            );

            // Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Joe", Salary = 85000, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Henry", Salary = 80000, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Sam", Salary = 60000, DepartmentId = 2 },
                new Employee { Id = 4, Name = "Max", Salary = 90000, DepartmentId = 1 },
                new Employee { Id = 5, Name = "Janet", Salary = 69000, DepartmentId = 1 },
                new Employee { Id = 6, Name = "Randy", Salary = 85000, DepartmentId = 1 },
                new Employee { Id = 7, Name = "Will", Salary = 70000, DepartmentId = 1 }
            );
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}