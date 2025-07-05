namespace PFLApp.DAL.Entity
{
    public class Stadion : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int Capacity { get; set; }
        public ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}
