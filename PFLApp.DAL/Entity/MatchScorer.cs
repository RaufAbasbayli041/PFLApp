using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Entity
{
    public class MatchScorer : BaseEntity
    {
        public int MatchId { get; set; }
        public Match Match { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int GoalsScored { get; set; } // The number of the goal in the match (e.g., 1st goal, 2nd goal, etc.)
    }
}
