using Microsoft.EntityFrameworkCore;

namespace _2356_Number_of_Unique_Subjects_Taught_by_Each_Teacher;

public class Solution
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public int DeptId { get; set; }
    }


    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");
                entity.HasKey(x=>new {x.TeacherId, x.SubjectId, x.DeptId});

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");
                entity.Property(e => e.SubjectId).HasColumnName("subject_id");
                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.HasData(
                    new Teacher { TeacherId = 1, SubjectId = 2, DeptId = 3 },
                    new Teacher { TeacherId = 1, SubjectId = 2, DeptId = 4 },
                    new Teacher { TeacherId = 1, SubjectId = 3, DeptId = 3 },
                    new Teacher { TeacherId = 2, SubjectId = 1, DeptId = 1 },
                    new Teacher { TeacherId = 2, SubjectId = 2, DeptId = 1 },
                    new Teacher { TeacherId = 2, SubjectId = 3, DeptId = 1 },
                    new Teacher { TeacherId = 2, SubjectId = 4, DeptId = 1 }
                );
            });
        }
    }
}