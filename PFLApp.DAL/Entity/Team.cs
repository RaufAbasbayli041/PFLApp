namespace PFLApp.DAL.Entity
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public int TeamNumber { get; set; }
        public int Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int GoalsScored { get; set; } = 0;
        public int AwayTeamId { get; set; }
        public int StadionId { get; set; }
        public Stadion Stadion { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
        //public ICollection<Match> HomeMatches { get; set; } = new List<Match>();
        //public ICollection<Match> AwayMatches { get; set; } = new List<Match>();
    }
}
