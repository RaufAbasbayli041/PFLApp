using PFLApp.DAL.DataBase;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.DAL.Repository.Implementation
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(PFLDBContext context) : base(context)
        {
        }
        // Additional methods specific to Team can be added here
    }
}
