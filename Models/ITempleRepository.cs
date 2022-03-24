using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTourProject.Models
{
    public interface ITempleRepository
    {
        IQueryable<Group> Groups { get; }
        IQueryable<Appointment> Appointments { get; }

        public void SaveGroup(Group g);
        public void CreateGroup(Group g);
        public void DeleteGroup(Group g);

        public void UpdateGroup(Group g);
       
    }
}
