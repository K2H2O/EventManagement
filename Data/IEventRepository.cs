using EventManagementSystem.Models;

namespace EventManagementSystem.Data
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEventById(int eventId);
        Event GetEventWithAttendees(int eventId);
        void AddAttendee(Attendee newRegistration);
        void SaveChanges();
    }

}