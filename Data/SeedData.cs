using Microsoft.EntityFrameworkCore;
using EventManagementSystem.Models;
using EventManagementSystem.Data;

namespace EventManagementSystem.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Events.Any())
            {
                context.Events.AddRange(
                    new Event
                    {
                        EventTitle = "Tech Summit 2025",
                        EventDescription = "Annual technology conference featuring keynote speakers and workshops",
                        EventStartDate = new DateTime(2025, 5, 15),
                        EventEndDate = new DateTime(2025, 5, 17),
                        EventLocation = "San Francisco Convention Center",
                        EventMaxAttendees = 2000
                    },

                    new Event
                    {
                        EventTitle = "Global Food Festival",
                        EventDescription = "Experience cuisines from around the world with live cooking demonstrations",
                        EventStartDate = new DateTime(2025, 6, 20),
                        EventEndDate = new DateTime(2025, 6, 22),
                        EventLocation = "Chicago Navy Pier",
                        EventMaxAttendees = 5000
                    },

                    new Event
                    {
                        EventTitle = "Marathon for Hope",
                        EventDescription = "Charity run supporting cancer research with 5K, 10K, and full marathon options",
                        EventStartDate = new DateTime(2025, 9, 12),
                        EventEndDate = new DateTime(2025, 9, 12),
                        EventLocation = "Boston Common",
                        EventMaxAttendees = 10000
                    },

                    new Event
                    {
                        EventTitle = "Winter Arts Fair",
                        EventDescription = "Local artists showcase paintings, sculptures, and handmade crafts",
                        EventStartDate = new DateTime(2025, 12, 5),
                        EventEndDate = new DateTime(2025, 12, 7),
                        EventLocation = "Denver Art Museum",
                        EventMaxAttendees = 800
                    },

                    new Event
                    {
                        EventTitle = "Startup Pitch Competition",
                        EventDescription = "Emerging entrepreneurs present their business ideas to investors",
                        EventStartDate = new DateTime(2025, 4, 10),
                        EventEndDate = new DateTime(2025, 4, 11),
                        EventLocation = "Austin Innovation Center",
                        EventMaxAttendees = 300
                    },

                    new Event
                    {
                        EventTitle = "Jazz in the Gardens",
                        EventDescription = "Outdoor jazz festival featuring world-renowned musicians",
                        EventStartDate = new DateTime(2025, 7, 25),
                        EventEndDate = new DateTime(2025, 7, 27),
                        EventLocation = "Miami Beach Amphitheater",
                        EventMaxAttendees = 7500
                    },

                    new Event
                    {
                        EventTitle = "Science Discovery Day",
                        EventDescription = "Interactive exhibits and experiments for kids and families",
                        EventStartDate = new DateTime(2025, 10, 18),
                        EventEndDate = new DateTime(2025, 10, 18),
                        EventLocation = "Smithsonian Museum, Washington DC",
                        EventMaxAttendees = 2500
                    },

                    new Event
                    {
                        EventTitle = "Yoga Retreat Weekend",
                        EventDescription = "Relaxing getaway with daily yoga sessions and mindfulness workshops",
                        EventStartDate = new DateTime(2025, 8, 8),
                        EventEndDate = new DateTime(2025, 8, 10),
                        EventLocation = "Sedona Red Rocks Resort",
                        EventMaxAttendees = 150
                    }
                );
                context.SaveChanges();
            }

        }
    }
}