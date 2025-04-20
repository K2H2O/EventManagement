using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required]
        [DisplayName("Description")]
        public string EventDescription { get; set; }
        [Required]
        [DisplayName("Title")]
        public string EventTitle { get; set; }
        [DisplayName("Start Date")]
        public DateTime EventStartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime? EventEndDate { get; set;}
        [Required]
        [DisplayName("Location")]
        public string EventLocation { get; set; }

        [Required]
        public int EventMaxAttendees { get; set; }

        public int EventRegistration { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
    }
}
