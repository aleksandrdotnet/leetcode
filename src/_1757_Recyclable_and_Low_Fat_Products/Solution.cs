using Microsoft.EntityFrameworkCore;

namespace _1757_Recyclable_and_Low_Fat_Products;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);
            
                entity.Property(e => e.LowFats)
                    .HasMaxLength(1)
                    .IsRequired();

                entity.Property(e => e.Recyclable)
                    .HasMaxLength(1)
                    .IsRequired();

                entity.HasData(
                    new Product { ProductId = 0, LowFats = "Y", Recyclable = "N" },
                    new Product { ProductId = 1, LowFats = "Y", Recyclable = "Y" },
                    new Product { ProductId = 2, LowFats = "N", Recyclable = "Y" },
                    new Product { ProductId = 3, LowFats = "Y", Recyclable = "Y" },
                    new Product { ProductId = 4, LowFats = "N", Recyclable = "N" }
                );
            });
        }
    }

    public class Product
    {
        public int ProductId { get; set; }

        // Строки 'Y' и 'N', можно представить как bool или enum
        public string LowFats { get; set; } = default!;
        public string Recyclable { get; set; } = default!;
    }

}