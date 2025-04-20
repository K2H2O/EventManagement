using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }

        [Required(ErrorMessage = "Enter your Name")]
        [DisplayName("Name")]
        public string AttendeeName { get; set; }
        [Required (ErrorMessage = "Enter your E-Mail")]
        [RegularExpression(".+\\@.+\\..+",  ErrorMessage = "Please Enter your Email")]
        [DisplayName("E-Mail")]
        public string AttendeeEmail { get; set; }
        [Required]
        public int EventID { get; set;}
        public Event Event { get; set; }
    }
}
