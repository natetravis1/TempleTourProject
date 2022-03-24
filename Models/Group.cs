using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourProject.Models
{
    //this refers to each individual group that signs up
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Date { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(0,15)]
        public int GroupSize { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }

        //foreign key relationship
        public int AppointmentId { get; set; }
    }
}
