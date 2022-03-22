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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            var times = from t in db.Tours.Include(t => t.AppointmentTime)
                         select t;
            return View();
        }

        public IActionResult GroupForm()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }
    }
}
