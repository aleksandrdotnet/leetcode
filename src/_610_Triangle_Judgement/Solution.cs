using Microsoft.EntityFrameworkCore;

namespace _596_Classes_With_at_Least_5_Students;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Courses");
                entity.HasKey(x => new { x.Student, x.Class });

                entity.Property(e => e.Student).HasColumnName("student").HasMaxLength(255);
                entity.Property(e => e.Class).HasColumnName("class").HasMaxLength(255);

                entity.HasData(
                    new Course { Student = "A", Class = "Math" },
                    new Course { Student = "B", Class = "English" },
                    new Course { Student = "C", Class = "Math" },
                    new Course { Student = "D", Class = "Biology" },
                    new Course { Student = "E", Class = "Math" },
                    new Course { Student = "F", Class = "Computer" },
                    new Course { Student = "G", Class = "Math" },
                    new Course { Student = "H", Class = "Math" },
                    new Course { Student = "I", Class = "Math" }
                );
            });
        }
    }

    public class Course
    {
        public string Student { get; set; } = null!;
        public string Class { get; set; } = null!;
    }
}