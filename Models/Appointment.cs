using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourProject.Models
{
    //this refers to the appointment slot
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }
        public string AppointmentTime { get; set; }
    }
}
