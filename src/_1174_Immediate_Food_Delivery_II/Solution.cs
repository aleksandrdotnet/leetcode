using Microsoft.EntityFrameworkCore;

namespace _1174_Immediate_Food_Delivery_II;

public class Solution
{
    public class Delivery
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CustomerPrefDeliveryDate { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("delivery_id");
                entity.Property(e => e.CustomerId).HasColumnName("customer_id");
                entity.Property(e => e.OrderDate).HasColumnName("order_date");
                entity.Property(e => e.CustomerPrefDeliveryDate).HasColumnName("customer_pref_delivery_date");

                entity.HasData(
                    new Delivery { Id = 1, CustomerId = 1, OrderDate = new DateTime(2019, 8, 1), CustomerPrefDeliveryDate = new DateTime(2019, 8, 2) },
                    new Delivery { Id = 2, CustomerId = 2, OrderDate = new DateTime(2019, 8, 2), CustomerPrefDeliveryDate = new DateTime(2019, 8, 2) },
                    new Delivery { Id = 3, CustomerId = 1, OrderDate = new DateTime(2019, 8, 11), CustomerPrefDeliveryDate = new DateTime(2019, 8, 12) },
                    new Delivery { Id = 4, CustomerId = 3, OrderDate = new DateTime(2019, 8, 24), CustomerPrefDeliveryDate = new DateTime(2019, 8, 24) },
                    new Delivery { Id = 5, CustomerId = 3, OrderDate = new DateTime(2019, 8, 21), CustomerPrefDeliveryDate = new DateTime(2019, 8, 22) },
                    new Delivery { Id = 6, CustomerId = 2, OrderDate = new DateTime(2019, 8, 11), CustomerPrefDeliveryDate = new DateTime(2019, 8, 13) },
                    new Delivery { Id = 7, CustomerId = 4, OrderDate = new DateTime(2019, 8, 9), CustomerPrefDeliveryDate = new DateTime(2019, 8, 9) }
                );
            });
        }
    }
}