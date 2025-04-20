using EventManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystem.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;
        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_eventRepository.GetAllEvents());
        }
        public IActionResult Details(int eventID)
        {
            var _event = _eventRepository.GetEventById(eventID);
        
            if(_event == null)
            {
            return NotFound();
            }
        return View(_event);
            }
    }   
}
