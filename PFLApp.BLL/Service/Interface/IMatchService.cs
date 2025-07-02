using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PFLApp.BLL.Models;
using PFLApp.DAL.Entity;

namespace PFLApp.BLL.Service.Interface
{
    public interface IMatchService
    {
        Task<DAL.Entity.Match> AddMatchAsync(MatchDto dto);
    }
}
