using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancerhome.entities
{
    public class product : baseEntity
    {
        public decimal prize { get; set; }

        public Class1 category { get; set; }
    }
}
