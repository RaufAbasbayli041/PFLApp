using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Models
{
    public record TeamResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
    }
}
