using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTourProject.Models.ViewModels
{
    public class TempleViewModel
    {
        public Appointment Appointment { get; set; }
        public IQueryable<Group> Groups { get; set; }
    }
}
