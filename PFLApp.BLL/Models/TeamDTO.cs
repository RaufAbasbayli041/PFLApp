using PFLApp.DAL.Entity;
using PFLApp.DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Match = PFLApp.DAL.Entity.Match;

namespace PFLApp.BLL.Models
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GoalsScored { get; set; }
        public ResultEnum Result { get; set; }
        // Navigation properties
        public ICollection<Player> Players { get; set; } = new List<Player>();
        public ICollection<Match> HomeMatches { get; set; } = new List<Match>();
        public ICollection<Match> AwayMatches { get; set; } = new List<Match>();


    }
}
