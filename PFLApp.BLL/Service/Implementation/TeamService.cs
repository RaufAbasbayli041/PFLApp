using AutoMapper;
using FluentValidation;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.BLL.Service.Repository;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.BLL.Service.Implementation
{
    public class TeamService : GenericService<Team, TeamDto>, ITeamService
    {
        public TeamService(ITeamRepository repository, IMapper mapper, IValidator<TeamDto> validator)
            : base(repository, mapper, validator)
        {
        }
        // Additional methods specific to Team can be added here
    }
}
