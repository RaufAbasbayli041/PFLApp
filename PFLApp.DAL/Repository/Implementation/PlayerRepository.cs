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
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(PFLDBContext context) : base(context)
        { }

        public async Task<IQueryable<Player >> GetAllAsync()
        {
            var entities = await _dbSet.Include(p => p.Team)
                                       .Where(t => !t.IsDeleted)
                                       .ToListAsync();
            return entities.AsQueryable();
        }
    }
}
