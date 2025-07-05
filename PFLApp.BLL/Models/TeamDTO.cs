using PFLApp.DAL.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Match = PFLApp.DAL.Entity.Match;

namespace PFLApp.BLL.Models
{
    public record TeamDto
    {
        public int Id { get; set; }
        public int TeamNumber { get; set; }
        public string? Name { get; set; }
        public int StadionId { get; set; }

        public int Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int GoalsScored { get; set; } = 0;
        public ICollection<PlayerDto> Players { get; set; } = new List<PlayerDto>();
        //public ICollection<MatchDto> HomeMatches { get; set; } = new List<MatchDto>();
        //public ICollection<MatchDto> AwayMatches { get; set; } = new List<MatchDto>();
    }
}
