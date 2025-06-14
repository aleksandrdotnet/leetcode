using Microsoft.EntityFrameworkCore;

namespace _610_Triangle_Judgement;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Triangle> Triangles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Triangle>(entity =>
            {
                entity.ToTable("Triangle");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.X).HasColumnName("x");
                entity.Property(e => e.Y).HasColumnName("y");
                entity.Property(e => e.Z).HasColumnName("z");

                entity.HasData(
                    new Triangle { Id = 1, X = 13, Y = 15, Z = 30 },
                    new Triangle { Id = 2, X = 10, Y = 20, Z = 15 },
                    new Triangle { Id = 3, X = 90, Y = 20, Z = 15 },
                    new Triangle { Id = 4, X = 40, Y = 20, Z = 15 }
                );
            });
        }
    }

    public class Triangle
    {
        public int Id { get; set; } // нужен PK для EF Core + SQLite
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}