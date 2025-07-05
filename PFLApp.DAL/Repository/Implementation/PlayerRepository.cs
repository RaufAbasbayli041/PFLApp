using PFLApp.DAL.DataBase;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.DAL.Repository.Implementation
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(PFLDBContext context) : base(context)
        { }
    }
}
