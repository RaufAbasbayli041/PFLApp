using AutoMapper;
using FluentValidation;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.BLL.Service.Repository;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Service.Implementation
{
    public class MatchService :GenericService<Match, MatchDto>, IMatchService
    {
        public MatchService(IMatchRepository repository,IMapper mapper,IValidator<MatchDto> validator ) : base(repository, mapper,validator)
        {
            
        }



    }
}
