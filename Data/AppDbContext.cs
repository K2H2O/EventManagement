using Microsoft.EntityFrameworkCore;
using EventManagementSystem.Models;

namespace EventManagementSystem.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<EventManagementSystem.Models.Event> Events { get; set; }
        public DbSet<EventManagementSystem.Models.Attendee> Attendees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EventManagementSystem.Models.Event>().ToTable("Event");
            modelBuilder.Entity<EventManagementSystem.Models.Attendee>().ToTable("Attendee");
        }
    }

}
