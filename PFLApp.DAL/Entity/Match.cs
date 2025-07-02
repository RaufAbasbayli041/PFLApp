using Microsoft.EntityFrameworkCore;
using PFLApp.DAL.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Entity
{
    [EntityTypeConfiguration(typeof(MatchConfigurations))]
    public class Match : BaseEntity
    {
        public DateTime MatchDate { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }      
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public List<MatchScorer> MatchScorers { get; set; } = new List<MatchScorer>();

    }
    
}
