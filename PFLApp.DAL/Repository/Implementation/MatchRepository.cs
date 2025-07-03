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
    public class MatchRepository : GenericRepository<Match>, IMatchRepository
    {
        public MatchRepository( PFLDBContext context ) : base(context)
        {
        }

    }
}
