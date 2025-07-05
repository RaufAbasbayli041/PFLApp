using PFLApp.BLL.Models;
using PFLApp.DAL.Entity;

namespace PFLApp.BLL.Service.Interface
{
    public interface IMatchService : IGenericService<Match, MatchDto>
    {
        Task<IEnumerable<MatchDto>> GetAllWithScoreAsync();
    }
}
