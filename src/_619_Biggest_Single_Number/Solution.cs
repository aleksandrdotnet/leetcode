using Microsoft.EntityFrameworkCore;

namespace _619_Biggest_Single_Number;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<MyNumber> MyNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyNumber>(entity =>
            {
                entity.ToTable("MyNumbers");
                entity.HasKey(x => x.Id);

                entity.Property(e => e.Num).HasColumnName("num");

                entity.HasData(
                    new MyNumber { Id = 1, Num = 8 },
                    new MyNumber { Id = 2, Num = 8 },
                    new MyNumber { Id = 3, Num = 3 },
                    new MyNumber { Id = 4, Num = 3 },
                    new MyNumber { Id = 5, Num = 1 },
                    new MyNumber { Id = 6, Num = 4 },
                    new MyNumber { Id = 7, Num = 5 },
                    new MyNumber { Id = 8, Num = 6 }
                );
            });
        }
    }

    public class MyNumber
    {
        public int Id { get; set; }
        public int Num { get; set; }
    }
}