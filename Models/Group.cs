using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourProject.Models
{
    public class Group
    {
        public string AppointmentTime { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
