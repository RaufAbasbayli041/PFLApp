namespace PFLApp.BLL.Models
{
    public record PlayerDto
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ShirtNumber { get; set; }
        public int GoalsScored { get; set; }
    }
}
