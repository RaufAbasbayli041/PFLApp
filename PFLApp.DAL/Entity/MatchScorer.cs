namespace PFLApp.DAL.Entity
{
    public class MatchScorer : BaseEntity
    {
        public int MatchId { get; set; }
        public Match Match { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int GoalsScored { get; set; }
    }
}
