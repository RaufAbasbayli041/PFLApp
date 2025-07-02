using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Entity
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }     
        public int ShirtNumber { get; set; }    
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int GoalsScored { get; set; }
    }
}
