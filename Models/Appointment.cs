using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourProject.Models
{
    //this refers to the appointment slot
    public class Appointment
    {
        [Key] 
        public int AppointmentId { get; set; }
        public string AppointmentTime { get; set; }
        public bool Taken { get; set; }
    }
}
