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
    public record TeamDto
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int StadionId { get; set; }
        public ResultEnum Result { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
        public ICollection<Match> HomeMatches { get; set; } = new List<Match>();
        public ICollection<Match> AwayMatches { get; set; } = new List<Match>();
    }
}
