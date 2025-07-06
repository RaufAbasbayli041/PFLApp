using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
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
    public class TeamService : GenericService<Team, TeamDto>, ITeamService
    {
        public TeamService(ITeamRepository repository, IMapper mapper, IValidator<TeamDto> validator)
            : base(repository, mapper, validator)
        {
        }
        public async Task<IQueryable<TeamDto>> GetAllAsync()
        {
            var datas = await _repository.GetAllAsync();
            return _mapper.Map<IQueryable<TeamDto>>(datas);
        }
        // Additional methods specific to Team can be added here
    }
}
