using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1729_Find_Followers_Count;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Follower> Followers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Follower>().HasKey(x => new { x.UserId, x.FollowerId });

            // Добавляем данные
            modelBuilder.Entity<Follower>().HasData(
                new Follower { UserId = 0, FollowerId = 1 },
                new Follower { UserId = 1, FollowerId = 0 },
                new Follower { UserId = 2, FollowerId = 0 },
                new Follower { UserId = 2, FollowerId = 1 }
            );
        }
    }

    public class Follower
    {
        [Column("user_id")] public int UserId { get; set; }

        [Column("follower_id")] public int FollowerId { get; set; }
    }
}