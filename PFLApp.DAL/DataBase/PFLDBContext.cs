using Microsoft.EntityFrameworkCore;
using PFLApp.DAL.Entity;

namespace PFLApp.DAL.DataBase
{
    public class PFLDBContext : DbContext
    {
        public PFLDBContext(DbContextOptions<PFLDBContext> options) : base(options)
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Stadion> Stadions { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchScorer> MatchScorers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PFLDBContext).Assembly);
        }

    }
}
