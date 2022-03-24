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
        public string GroupName { get; set; }
        public int GroupSize { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //foreign key relationship
        public int AppointmentId { get; set; }
    }
}
