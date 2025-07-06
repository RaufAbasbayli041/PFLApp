using Microsoft.EntityFrameworkCore;
using PFLApp.DAL.DataBase;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Repository.Implementation
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(PFLDBContext context) : base(context)
        {
        }
        public async Task<IQueryable<Team>> GetAllAsync()
        {
            var entities = await _dbSet.Include(t => t.Stadion)
                                       .Include(Team => Team.Players)
                                       .Where(t => !t.IsDeleted)
                                       .ToListAsync();
            return entities.AsQueryable();
        }
    }
}
