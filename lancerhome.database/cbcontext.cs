using lancerhome.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancerhome.database
{
    public class cbcontext : DbContext 
    {
        public cbcontext () : base("lancerhomeconnection")
        {
        }
        public DbSet<product> product { get; set; }

        public DbSet<Class1> class1  { get; set; }
    }
}
