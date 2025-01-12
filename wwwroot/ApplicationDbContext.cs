using Inversity_test.Models;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Location> Locations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Sample data
        modelBuilder.Entity<Location>().HasData(
            new Location { Id = 1, Name = "London", Latitude = 51.505, Longitude = -0.09, Cases = 200, Illness = "Influenza" },
            new Location { Id = 2, Name = "Manchester", Latitude = 53.483, Longitude = -2.244, Cases = 75, Illness = "COVID19" },
            new Location { Id = 3, Name = "Birmingham", Latitude = 52.486, Longitude = -1.890, Cases = 105, Illness = "COVID19" },
            new Location { Id = 4, Name = "Liverpool", Latitude = 53.400, Longitude = -2.983, Cases = 40, Illness = "Common Cold" },
            new Location { Id = 5, Name = "Bristol", Latitude = 51.4545, Longitude = -2.5879, Cases = 12, Illness = "Influenza" },
            new Location { Id = 6, Name = "Truro", Latitude = 50.2644, Longitude = -5.0513, Cases = 120, Illness = "Norovirus" },
            new Location { Id = 7, Name = "Abu Dhabi", Latitude = 24.4539, Longitude = 54.3773, Cases = 170, Illness = "Heatstroke" }
        );
    }
}