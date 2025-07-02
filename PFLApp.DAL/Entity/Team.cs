using PFLApp.DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Entity
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public int TeamNumber { get; set; }
        public ResultEnum Result { get; set; }
        public int StadionId { get; set; }
        public Stadion Stadion { get; set; }
        public int GoalsScored { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
        public ICollection<Match> HomeMatches { get; set; } = new List<Match>();
        public ICollection<Match> AwayMatches { get; set; } = new List<Match>();


    }
}
