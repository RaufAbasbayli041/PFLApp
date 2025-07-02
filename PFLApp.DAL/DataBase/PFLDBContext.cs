using Microsoft.EntityFrameworkCore;
using PFLApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.DataBase
{
    public class PFLDBContext : DbContext
    {
        public PFLDBContext(DbContextOptions<PFLDBContext> options) : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchScorer> MatchScorers { get; set; }
        public DbSet<Stadion> Stadions { get; set; }
        
    }
}
