using Microsoft.EntityFrameworkCore;

namespace _1890_The_Latest_Login_in_2020;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasKey(l => new { l.UserId, l.TimeStamp }); // составной ключ, чтобы seed сработал

            modelBuilder.Entity<Login>().HasData(
                new Login { UserId = 6, TimeStamp = DateTime.Parse("2020-06-30 15:06:07") },
                new Login { UserId = 6, TimeStamp = DateTime.Parse("2021-04-21 14:06:06") },
                new Login { UserId = 6, TimeStamp = DateTime.Parse("2019-03-07 00:18:15") },
                new Login { UserId = 8, TimeStamp = DateTime.Parse("2020-02-01 05:10:53") },
                new Login { UserId = 8, TimeStamp = DateTime.Parse("2020-12-30 00:46:50") },
                new Login { UserId = 2, TimeStamp = DateTime.Parse("2020-01-16 02:49:50") },
                new Login { UserId = 2, TimeStamp = DateTime.Parse("2019-08-25 07:59:08") },
                new Login { UserId = 14, TimeStamp = DateTime.Parse("2019-07-14 09:00:00") },
                new Login { UserId = 14, TimeStamp = DateTime.Parse("2021-01-06 11:59:59") }
            );
        }
    }

    public class Login
    {
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}