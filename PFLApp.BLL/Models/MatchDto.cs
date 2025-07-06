using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Models
{
    public record MatchDto
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int HomeTeamId { get; set; }
        public string? HomeTeamName { get; set; }
        public int AwayTeamId { get; set; }
        public string? AwayTeamName { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public List<MatchScorerDto> Score { get; set; } = new List<MatchScorerDto>();
    }
}
