using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using EventManagementSystem.Models;
using EventManagementSystem.Data;
using System.ComponentModel.Design;

namespace EventManagementSystem.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly IEventRepository _eventRepository;
        public AttendeeController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        [HttpGet]
        public IActionResult Register(int eventID)
        {
            var eventDetails = _eventRepository.GetEventById(eventID);
            if (eventDetails == null)
            {
                return NotFound();
            }
            var registration = new Attendee { EventID = eventID };
            return View(registration);

        }
        [HttpPost]
        public IActionResult Register(Attendee attendee)
        {

            var Event = _eventRepository.GetEventById(attendee.EventID);
            if (Event != null)
            {
                Event.EventRegistration++;
            }
            _eventRepository.AddAttendee(attendee);
            _eventRepository.SaveChanges();

            return RedirectToAction("Confirmation", new { eventId = attendee.EventID });

        }
   

        [HttpGet]
        public IActionResult Confirmation(int eventId)
        {
            var myEvent = _eventRepository.GetEventWithAttendees(eventId);
            if (myEvent == null)
            {
                return NotFound();
            }
            return View(myEvent);
        }
    }
}
