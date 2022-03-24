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
        public IActionResult AddGroupForm(int TimeId, string Time)
        {
            //have appointments time and date already loaded in

            return View(new TempleViewModel
            {
                Appointment = repo.Appointments.Single(t => t.AppointmentId == TimeId && t.AppointmentTime == Time)
            });
        }
        [HttpPost]
        public IActionResult AddGroupForm(TempleViewModel tvm, int TimeId, string Time)
        {
            //check to make sure this works
            if (ModelState.IsValid)
            {

                if (tvm.Appointment.Taken == false)
                {

                    tvm.Group.AppointmentId = TimeId;
                    tvm.Group.AppointmentTime = Time;
     
                    tvm.Appointment.Taken = true;
                    var app = repo.Appointments.Single(t => t.AppointmentId == TimeId && t.AppointmentTime == Time);
                    app.Taken = true;

                    repo.CreateGroup(tvm.Group);
                    repo.SaveGroup(tvm.Group);
          
                    return RedirectToAction("Index");
                } 
            }
            
            return View(tvm);
            
        }

        //this is for viewing individual appointments listed out in a table
        public IActionResult ListGroups()
        {
            var groups = repo.Groups
                .ToList();

            return View(groups);

        }
        

        [HttpGet]
        public IActionResult Edit (int groupid)
        {
            var group = repo.Groups.Single(x => x.GroupId == groupid);

            return View("Edit", group);
        }

        [HttpPost]
        public IActionResult Edit(Group g)
        {
            repo.UpdateGroup(g);
            repo.SaveGroup(g);
            return RedirectToAction("ListGroups");
        }

        [HttpGet]
        public IActionResult Delete (int groupid)
        {
            var group = repo.Groups.Single(x => x.GroupId == groupid);

            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(Group g)
        {
            repo.DeleteGroup(g);
            repo.SaveGroup(g);
            return RedirectToAction("ListGroups");
        }

    }
}
