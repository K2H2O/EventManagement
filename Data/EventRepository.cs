
using EventManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using EventManagementSystem.Models;
using System.Runtime.CompilerServices;

namespace EventManagementSystem.Data
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;
        public EventRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddAttendee(Attendee newRegistration)
        {
            _context.Attendees.Add(newRegistration);
        }

        public IEnumerable<EventManagementSystem.Models.Event> GetAllEvents()
        {
            return _context.Events;
        }

        public Event GetEventById(int eventId)
        {
            return _context.Events.FirstOrDefault(e => e.EventID == eventId);
        }

        public Event GetEventWithAttendees(int eventId)
        {
            return _context.Events.Include(e => e.Attendees).FirstOrDefault(e => e.EventID == eventId);

        }

        public void SaveChanges()
        {
            _context.SaveChanges();    
        }
    }
}
