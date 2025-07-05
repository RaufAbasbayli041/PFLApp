namespace PFLApp.BLL.Models
{
    public record StadionDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Capacity { get; set; }
    }
}
