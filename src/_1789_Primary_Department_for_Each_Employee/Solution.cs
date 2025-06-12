using Microsoft.EntityFrameworkCore;

namespace _1789_Primary_Department_for_Each_Employee;

public class Solution
{
    public enum PrimaryFlag
    {
        Y,
        N
    }
    
    public class Employee
    {
        public int Id { get; set; } // требуется PK для EF Core
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public PrimaryFlag PrimaryFlag { get; set; }
    }
    
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.PrimaryFlag)
                    .HasColumnName("primary_flag")
                    .HasConversion<string>()  // enum -> 'Y' / 'N'
                    .HasMaxLength(1);

                entity.HasData(
                    new Employee { Id = 1, EmployeeId = 1, DepartmentId = 1, PrimaryFlag = PrimaryFlag.N },
                    new Employee { Id = 2, EmployeeId = 2, DepartmentId = 1, PrimaryFlag = PrimaryFlag.Y },
                    new Employee { Id = 3, EmployeeId = 2, DepartmentId = 2, PrimaryFlag = PrimaryFlag.N },
                    new Employee { Id = 4, EmployeeId = 3, DepartmentId = 3, PrimaryFlag = PrimaryFlag.N },
                    new Employee { Id = 5, EmployeeId = 4, DepartmentId = 2, PrimaryFlag = PrimaryFlag.N },
                    new Employee { Id = 6, EmployeeId = 4, DepartmentId = 3, PrimaryFlag = PrimaryFlag.Y },
                    new Employee { Id = 7, EmployeeId = 4, DepartmentId = 4, PrimaryFlag = PrimaryFlag.N }
                );
            });
        }
    }
}