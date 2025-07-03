using AutoMapper;
using PFLApp.BLL.Models;
using PFLApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Profiles
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<Match, MatchDto>().ReverseMap();  
            CreateMap<Player, PlayerDto>().ReverseMap();
            CreateMap<Stadion, StadionDto>().ReverseMap();

        }
    }
}
