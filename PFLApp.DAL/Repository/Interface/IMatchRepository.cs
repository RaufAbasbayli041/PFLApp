using PFLApp.DAL.Entity;

namespace PFLApp.DAL.Repository.Interface
{
    public interface IMatchRepository : IGenericRepository<Match>
    {
        Task<IEnumerable<Match>> GetAllWithScoreAsync();
    }
}
