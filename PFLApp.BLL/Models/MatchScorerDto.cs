using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Models
{
    public record MatchScorerDto
    {
        public int PlayerId { get; set; }
        public int GoalsScored { get; set; }
    }
}
