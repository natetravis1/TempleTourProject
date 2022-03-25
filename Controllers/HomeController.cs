using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            return View();
        }

        //this is the options for choosing an appointment time and date
 
        public IActionResult SignUp (string curdate)
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

            if (curdate == null)
            {
                curdate = DateTime.Now.ToString("MM/dd/yyyy");
            }

            ViewBag.CurDate = curdate;

            string[] formats = { "MM/dd/yyyy" };
            DateTime current = DateTime.ParseExact(curdate, formats, System.Globalization.CultureInfo.InvariantCulture);

            ViewBag.Disable = false;

            if (current.AddDays(-1) < DateTime.Today)
            {
                ViewBag.Disable = true;
            }

            var appointments = repo.Appointments
                .ToList();

            return View(appointments);
        }

        public IActionResult PreviousDate(string curDate)
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

            string[] formats = { "MM/dd/yyyy" };
            DateTime curdate = DateTime.ParseExact(curDate, formats, System.Globalization.CultureInfo.InvariantCulture);
            DateTime previousDate = curdate.AddDays(-1);
            string s_previous = previousDate.ToString("MM/dd/yyyy");

            ViewBag.CurDate = s_previous;

            return RedirectToAction("Signup", new { curdate = s_previous });
        }

        public IActionResult NextDate(string curDate)
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

            string[] formats = { "MM/dd/yyyy" };
            DateTime curdate = DateTime.ParseExact(curDate, formats, System.Globalization.CultureInfo.InvariantCulture);
            DateTime nextDate = curdate.AddDays(1);
            string s_next = nextDate.ToString("MM/dd/yyyy");

            ViewBag.CurDate = s_next;

            return RedirectToAction("Signup", new { curdate = s_next });
        }

        //this is for finalizing an appointment
        [HttpGet]
        public IActionResult AddGroupForm(int TimeId, string Time, string Date)
        {
            //have appointments time and date already loaded in
            ViewBag.CurDate = Date;

            if (HttpContext.Session.GetString("date") == null)
            {
                HttpContext.Session.SetString("date", Date);
            }
            else
            {
                ViewBag.CurDate = HttpContext.Session.GetString("date");
            }

            return View(new TempleViewModel
            {
                Appointment = repo.Appointments.Single(t => t.AppointmentId == TimeId && t.AppointmentTime == Time)
            });
        }
        [HttpPost]
        public IActionResult AddGroupForm(TempleViewModel tvm, int TimeId, string Time)
        {
            //check to make sure this works
            if (tvm.Appointment.Date == null)
            {
                tvm.Appointment.Date = HttpContext.Session.GetString("date");
            }
            
            if (ModelState.IsValid)
            {

                if (tvm.Appointment.Taken == false)
                {

                    tvm.Group.AppointmentId = TimeId;
                    tvm.Group.AppointmentTime = Time;
                    tvm.Group.Date = tvm.Appointment.Date;
     
                    tvm.Appointment.Taken = true;
                    var app = repo.Appointments.Single(t => t.AppointmentId == TimeId && t.AppointmentTime == Time);
                    app.Taken = true;

                    repo.CreateGroup(tvm.Group);
                    repo.SaveGroup(tvm.Group);

                    ViewBag.CurDate = "";

                    HttpContext.Session.Remove("date");
                    

                    return RedirectToAction("Index");
                } 
            }
            
            return View(tvm);
            
        }

        //this is for viewing individual appointments listed out in a table
        public IActionResult ListGroups()
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

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
