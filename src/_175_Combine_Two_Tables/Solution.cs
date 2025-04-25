using Microsoft.EntityFrameworkCore;

namespace _175_Combine_Two_Tables;

public class Solution
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("TestDb");
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(p => p.PersonId);
            modelBuilder.Entity<Address>().HasKey(a => a.AddressId);

            modelBuilder.Entity<Person>().HasData(
                new Person { PersonId = 1, FirstName = "Allen", LastName = "Wang" },
                new Person { PersonId = 2, FirstName = "Bob", LastName = "Alice" }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address { AddressId = 1, PersonId = 2, City = "New York City", State = "New York" },
                new Address { AddressId = 2, PersonId = 3, City = "Leetcode", State = "California" }
            );
        }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public class Address
    {
        public int AddressId { get; set; }
        public int PersonId { get; set; }
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
    }
}