using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTourProject.Models
{
    public class TempleTourContext : DbContext
    {
        public TempleTourContext (DbContextOptions<TempleTourContext> options) : base(options)
        {
            //Leave blank for now
        }


        public DbSet<Group> Groups { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {

        }
    }
}
