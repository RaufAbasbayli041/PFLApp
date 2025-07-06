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
            CreateMap<Team, TeamDto>().ForMember(dest => dest.StadionName, opt => opt.MapFrom(src => src.Stadion.Name))
                                      .ReverseMap();
            CreateMap<TeamDto, Team>()
    .ForMember(dest => dest.Stadion, opt => opt.Ignore());
            CreateMap<Match, MatchDto>().ReverseMap();
            CreateMap<MatchDto, Match>()
                .ForMember(dest => dest.HomeTeam, opt => opt.Ignore())
                .ForMember(dest => dest.AwayTeam, opt => opt.Ignore());
              
            CreateMap<Player, PlayerDto>().ReverseMap();
            CreateMap<PlayerDto, Player>()
                .ForMember(dest => dest.Team, opt => opt.Ignore());
                
            CreateMap<Stadion, StadionDto>().ReverseMap();

        }
    }
}
