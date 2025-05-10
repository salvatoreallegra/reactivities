using System;
using Domain;
namespace Persistence;
public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any())
        {
            return; // DB has been seeded
        }

        var activities = new List<Activity>
        {
            new Activity
            {
                Title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 months ago",
                Category = "drinks",
                City = "London",
                Venue = "Pub",
                IsCancelled = false,
                Latitude = 51.5074,
                Longitude = -0.1278
            },
            new Activity
            {
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(2),
                Description = "Activity 2 months in future",
                Category = "culture",
                City = "London",
                Venue = "British Museum",
                IsCancelled = false,
                Latitude = 51.5074,
                Longitude = -0.1278
            }
        };

        await context.Activities.AddRangeAsync(activities);
        await context.SaveChangesAsync();
    }
}