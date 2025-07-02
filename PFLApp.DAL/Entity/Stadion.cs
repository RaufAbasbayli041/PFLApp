using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Entity
{
    public class Stadion : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Team Team { get; set; }       
       
    }

}
