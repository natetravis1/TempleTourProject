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
        public IActionResult SignUp()
        {
            //var times = from t in db.Tours.Include(t => t.AppointmentTime)
            //            select t;

            //preload available appointments in
            var appointments = repo.Appointments
                .ToList();
                
                repo.Appointments.ToList();

            return View(appointments);
        }

        //this is for finalizing an appointment
        [HttpGet]
        public IActionResult AddGroupForm()
        {
            //have appointments time and date already loaded in
           
            
            return View();
        }
        [HttpPost]
        public IActionResult AddGroupForm(Group group)
        {
            //check to make sure this works
            if (ModelState.IsValid)
            {
                //repo.CreateGroup(group);
                //repo.SaveGroup(group);
                return View("Confirmation", group);
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
