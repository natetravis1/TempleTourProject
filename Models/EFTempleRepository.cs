using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTourProject.Models
{
    public class EFTempleRepository : ITempleRepository
    {
        private TempleTourContext context { get; set; }

        public EFTempleRepository(TempleTourContext temp) => context = temp;

        public IQueryable<Group> Groups => context.Groups;
        public IQueryable<Appointment> Appointments => context.Appointments;

        public void CreateGroup(Group g)
        {
            context.Add(g);
            context.SaveChanges();
        }

        public void DeleteGroup(Group g)
        {
            context.Remove(g);
            context.SaveChanges();
        }

        public void SaveGroup(Group g)
        {
            context.SaveChanges();
        }
    }
}
