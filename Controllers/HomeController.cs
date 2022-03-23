using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TempleTourProject.Models;

namespace TempleTourProject.Controllers
{
    public class HomeController : Controller
    {
        private 
        
        //this is the home
        public IActionResult Index()
        {
            return View();
        }

        //this is the options for choosing an appointment
        public IActionResult SignUp()
        {
            //var times = from t in db.Tours.Include(t => t.AppointmentTime)
            //             select t;
            return View();
        }

        //this is for adding an appointment
        public IActionResult GroupForm()
        {
            return View();
        }

        //this is for viewing appointments
        public IActionResult Appointments()
        {
            return View();
        }

    }
}
