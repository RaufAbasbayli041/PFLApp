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
    public class StadionRepository : GenericRepository<Stadion>, IStadionRepository
    {
        public StadionRepository(PFLDBContext context) : base(context)
        {
        }
        // Additional methods specific to Stadion can be added here if needed
    }
}
