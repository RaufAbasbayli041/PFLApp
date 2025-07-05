using PFLApp.DAL.DataBase;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.DAL.Repository.Implementation
{
    public class StadionRepository : GenericRepository<Stadion>, IStadionRepository
    {
        public StadionRepository(PFLDBContext context) : base(context)
        {
        }
        // Additional methods specific to Stadion can be added here if needed
    }
}
