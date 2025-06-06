using Microsoft.EntityFrameworkCore;

namespace _1193_Monthly_Transactions_I;

public class Solution
{
    public enum TransactionState
    {
        approved,
        declined
    }

    public class Transaction
    {
        public int Id { get; set; }
        public string Country { get; set; } = null!;
        public TransactionState State { get; set; }
        public int Amount { get; set; }
        public DateTime TransDate { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transactions");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Country).HasColumnName("country").HasMaxLength(4);
                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasConversion<string>(); // enum as string (e.g., "approved")
                entity.Property(e => e.Amount).HasColumnName("amount");
                entity.Property(e => e.TransDate).HasColumnName("trans_date");

                entity.HasData(
                    new Transaction
                    {
                        Id = 121, Country = "US", State = TransactionState.approved, Amount = 1000,
                        TransDate = new DateTime(2018, 12, 18)
                    },
                    new Transaction
                    {
                        Id = 122, Country = "US", State = TransactionState.declined, Amount = 2000,
                        TransDate = new DateTime(2018, 12, 19)
                    },
                    new Transaction
                    {
                        Id = 123, Country = "US", State = TransactionState.approved, Amount = 2000,
                        TransDate = new DateTime(2019, 01, 01)
                    },
                    new Transaction
                    {
                        Id = 124, Country = "DE", State = TransactionState.approved, Amount = 2000,
                        TransDate = new DateTime(2019, 01, 07)
                    }
                );
            });
        }
    }
}