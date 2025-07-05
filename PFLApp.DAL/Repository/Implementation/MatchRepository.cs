using Microsoft.EntityFrameworkCore;
using PFLApp.DAL.DataBase;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.DAL.Repository.Implementation
{
    public class MatchRepository : GenericRepository<Match>, IMatchRepository
    {
        public MatchRepository(PFLDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Match>> GetAllWithScoreAsync()
        {
            var data = await _context.Matches
                .Include(x => x.AwayTeam)
                .Include(x => x.HomeTeam)
                .Include(x => x.AwayTeam.Players)
                .Include(x => x.HomeTeam.Players)
                .Where(x => !x.IsDeleted)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }
    }
}
