namespace PFLApp.BLL.Models
{
    public record MatchDto
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public List<MatchScorerDto> Goals { get; set; }
    }
}
