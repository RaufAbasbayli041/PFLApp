using PFLApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Repository.Interface
{
    public interface IMatchRepository : IGenericRepository<Match>
    {
       Task <IEnumerable<Match>> GetAllWithScoreAsync();
    }
}
