using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTourProject.Models
{
    public class TempleTourContext : DbContext
    {
        public TempleTourContext (DbContextOptions<TempleTourContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<Appointment> newappointment { get; set; }
        public DbSet<Group> Groups { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, AppointmentTime = "8 AM"},
                new Appointment { AppointmentId = 1, AppointmentTime = "9 AM" },
                new Appointment { AppointmentId = 1, AppointmentTime = "10 AM" },
                new Appointment { AppointmentId = 1, AppointmentTime = "11 AM" },
                new Appointment { AppointmentId = 1, AppointmentTime = "12 AM" },
                new Appointment { AppointmentId = 1, AppointmentTime = "1 PM" },
                new Appointment { AppointmentId = 1, AppointmentTime = "2 PM" }
            );
            mb.Entity<Group>().HasData(
                new  Group { 
                    GroupId = 1, 
                    AppointmentId = 1,
                    GroupName = "Sarah's Group",
                    GroupSize = 2,
                    Email = "sarahlolmstead999@gmail.com",
                    Phone = "801-435-1276"
                },
                new Group
                {
                    GroupId = 2,
                    AppointmentId = 2,
                    GroupName = "Spencer's Group",
                    GroupSize = 8,
                    Email = "profhilton@gmail.com",
                    Phone = "385-789-6932"
                }
            );
        }
    }
}
