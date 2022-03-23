using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TempleTourProject.Models;
using TempleTourProject.Models.ViewModels;

namespace TempleTourProject.Controllers
{
    public class HomeController : Controller
    {
        private ITempleRepository repo;

        public HomeController(ITempleRepository temp) => repo = temp;
        
        public IActionResult Index()
        {
            return View();
        }

        //this is the options for choosing an appointment time and date
 
        public IActionResult SignUp ()
        {
           
            var appointments = repo.Appointments
                .ToList();

            return View(appointments);
        }

        //[HttpPost]
        //public IActionResult SignUp(int appointmentid)
        //{
        //    var x = repo.Appointments.Where(x => x.AppointmentId == appointmentid);
        //    return View(x);
        //}

        //this is for finalizing an appointment
        [HttpGet]
        public IActionResult AddGroupForm(int TimeId)
        {
            //have appointments time and date already loaded in
            //var x = repo.Groups.Single(x => x.AppointmentId == timeId);


            //var x = new TempleViewModel
            //{
            //    Group 
            //    //Group = repo.Groups.Single(t => t.AppointmentId == TimeId)
            //};

            //var x = new TempleViewModel
            //{
            //    //Group = repo.Groups.Where(t => t.AppointmentId == TimeId),
            //    Appointment = repo.Appointments.Single(t => t.AppointmentId == TimeId),
            //    Group = new Group()
            //};


            return View(new TempleViewModel
            {
                Appointment = repo.Appointments.Single(t => t.AppointmentId == TimeId)
            });
        }
        [HttpPost]
        public IActionResult AddGroupForm(TempleViewModel tvm)
        {
            //check to make sure this works
            if (ModelState.IsValid)
            {
                repo.CreateGroup(tvm.Group);
                repo.SaveGroup(tvm.Group);
                return View("Index");
            }
            else
            {
    
                return View();
            }
        }

        //this is for viewing individual appointments listed out in a table
        public IActionResult ListGroups()
        {
            //var groups = repo.Groups.ToList();
            return View();
        }

    }
}
