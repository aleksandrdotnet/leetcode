using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1661_Average_Time_of_Process_per_Machine;

public class Solution
{
    public class Activity
    {
        public int machine_id { get; set; }

        public int process_id { get; set; }

        public string activity_type { get; set; }

        public double timestamp { get; set; }
    }

    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity");

            builder.HasKey(a => new
            {
                MachineId = a.machine_id, ProcessId = a.process_id, ActivityType = a.activity_type,
                Timestamp = a.timestamp
            });

            builder.Property(a => a.activity_type)
                .HasConversion<string>() // enum → string
                .IsRequired();

            builder.Property(a => a.timestamp)
                .IsRequired();
        }
    }

    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=:memory:");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());

            modelBuilder.Entity<Activity>().HasData(
                new Activity { machine_id = 0, process_id = 0, activity_type = "Start", timestamp = 0.712 },
                new Activity { machine_id = 0, process_id = 0, activity_type = "End", timestamp = 1.52 },
                new Activity { machine_id = 0, process_id = 1, activity_type = "Start", timestamp = 3.14 },
                new Activity { machine_id = 0, process_id = 1, activity_type = "End", timestamp = 4.12 },
                new Activity { machine_id = 1, process_id = 0, activity_type = "Start", timestamp = 0.55 },
                new Activity { machine_id = 1, process_id = 0, activity_type = "End", timestamp = 1.55 },
                new Activity { machine_id = 1, process_id = 1, activity_type = "Start", timestamp = 0.43 },
                new Activity { machine_id = 1, process_id = 1, activity_type = "End", timestamp = 1.42 },
                new Activity { machine_id = 2, process_id = 0, activity_type = "Start", timestamp = 4.1 },
                new Activity { machine_id = 2, process_id = 0, activity_type = "End", timestamp = 4.512 },
                new Activity { machine_id = 2, process_id = 1, activity_type = "Start", timestamp = 2.5 },
                new Activity { machine_id = 2, process_id = 1, activity_type = "End", timestamp = 5.0 }
            );
        }
    }
}