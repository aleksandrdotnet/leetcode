using Microsoft.EntityFrameworkCore;

namespace _1251_Average_Selling_Price;

public class Solution
{
    public class Price
    {
        public int Id { get; set; } // Primary key
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PriceAmount { get; set; } // maps to "price"
    }

    public class UnitSold
    {
        public int Id { get; set; } // Primary key
        public int ProductId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Units { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Price> Prices { get; set; }
        public DbSet<UnitSold> UnitsSold { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("Prices");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.ProductId).HasColumnName("product_id");
                entity.Property(e => e.StartDate).HasColumnName("start_date");
                entity.Property(e => e.EndDate).HasColumnName("end_date");
                entity.Property(e => e.PriceAmount).HasColumnName("price");

                entity.HasData(
                    new Price { Id = 1, ProductId = 1, StartDate = DateTime.Parse("2019-02-17"), EndDate = DateTime.Parse("2019-02-28"), PriceAmount = 5 },
                    new Price { Id = 2, ProductId = 1, StartDate = DateTime.Parse("2019-03-01"), EndDate = DateTime.Parse("2019-03-22"), PriceAmount = 20 },
                    new Price { Id = 3, ProductId = 2, StartDate = DateTime.Parse("2019-02-01"), EndDate = DateTime.Parse("2019-02-20"), PriceAmount = 15 },
                    new Price { Id = 4, ProductId = 2, StartDate = DateTime.Parse("2019-02-21"), EndDate = DateTime.Parse("2019-03-31"), PriceAmount = 30 }
                );
            });

            modelBuilder.Entity<UnitSold>(entity =>
            {
                entity.ToTable("UnitsSold");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.ProductId).HasColumnName("product_id");
                entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");
                entity.Property(e => e.Units).HasColumnName("units");

                entity.HasData(
                    new UnitSold { Id = 1, ProductId = 1, PurchaseDate = DateTime.Parse("2019-02-25"), Units = 100 },
                    new UnitSold { Id = 2, ProductId = 1, PurchaseDate = DateTime.Parse("2019-03-01"), Units = 15 },
                    new UnitSold { Id = 3, ProductId = 2, PurchaseDate = DateTime.Parse("2019-02-10"), Units = 200 },
                    new UnitSold { Id = 4, ProductId = 2, PurchaseDate = DateTime.Parse("2019-03-22"), Units = 30 }
                );
            });
        }
    }
}