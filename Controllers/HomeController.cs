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
        private ITempleRepository repo;

        public HomeController(ITempleRepository temp) => repo = temp;
        
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
        [HttpGet]
        public IActionResult AddGroupForm()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddGroupForm(Group group)
        {
            //check to make sure this works
            if (ModelState.IsValid)
            {
                repo.CreateGroup(group);
                repo.SaveGroup(group);
                return View("Confirmation", group);
            }
            else
            {
                ViewBag.Groups = repo.Groups.ToList();
                return View();
            }
        }

        //this is for viewing individual appointments
        public IActionResult ListGroups()
        {
            return View();
        }

    }
}
