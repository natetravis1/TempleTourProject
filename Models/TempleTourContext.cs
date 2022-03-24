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

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Group> Groups { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, AppointmentTime = "8 AM"},
                new Appointment { AppointmentId = 2, AppointmentTime = "9 AM" },
                new Appointment { AppointmentId = 3, AppointmentTime = "10 AM" },
                new Appointment { AppointmentId = 4, AppointmentTime = "11 AM" },
                new Appointment { AppointmentId = 5, AppointmentTime = "12 AM" },
                new Appointment { AppointmentId = 6, AppointmentTime = "1 PM" },
                new Appointment { AppointmentId = 7, AppointmentTime = "2 PM" },
                new Appointment { AppointmentId = 8, AppointmentTime = "3 PM" },
                new Appointment { AppointmentId = 9, AppointmentTime = "4 PM" },
                new Appointment { AppointmentId = 10, AppointmentTime = "5 PM" },
                new Appointment { AppointmentId = 11, AppointmentTime = "6 PM" },
                new Appointment { AppointmentId = 12, AppointmentTime = "7 PM" },
                new Appointment { AppointmentId = 13, AppointmentTime = "8 PM" }
            );
            mb.Entity<Group>().HasData(
                new  Group {
                    Date = "3/25/22",
                    GroupId = 1, 
                    AppointmentId = 1,
                    GroupName = "Sarah's Group",
                    GroupSize = 2,
                    Email = "sarahlolmstead999@gmail.com",
                    Phone = "801-435-1276"
                },
                new Group
                {
                    Date = "4/18/22",
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
