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

        //this is for finalizing an appointment
        [HttpGet]
        public IActionResult AddGroupForm(int TimeId)
        {
            //have appointments time and date already loaded in

            return View(new TempleViewModel
            {
                Appointment = repo.Appointments.Single(t => t.AppointmentId == TimeId)
            });
        }
        [HttpPost]
        public IActionResult AddGroupForm(TempleViewModel tvm, int TimeId)
        {
            //check to make sure this works
            if (ModelState.IsValid)
            {
                //var apptime = repo.Appointments.Single(t => t.AppointmentId);
                //repo.Appointments.FirstOrDefault(t => t.AppointmentId == TimeId);
                tvm.Group.AppointmentId = TimeId;
                //tvm.Group.Appointment = tvm.Appointment;

                repo.CreateGroup(tvm.Group);
                repo.SaveGroup(tvm.Group);

                
                return RedirectToAction("Index");
            }
            else
            {
    
                return View(tvm);
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
