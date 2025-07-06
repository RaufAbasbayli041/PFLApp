using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.BLL.Service.Repository;
using PFLApp.DAL.DataBase;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Match = PFLApp.DAL.Entity.Match;

namespace PFLApp.BLL.Service.Implementation
{
    public class MatchService : GenericService<Match, MatchDto>, IMatchService
    {
        private readonly IMatchRepository _repository;
        private readonly PFLDBContext _context;
        public MatchService(IMatchRepository repository, IMapper mapper, IValidator<MatchDto> validator, PFLDBContext context) : base(repository, mapper, validator)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<IEnumerable<MatchDto>> GetAllWithScoreAsync()
        {
            var data = await _repository.GetAllWithScoreAsync();
            if (data == null || !data.Any())
            {
                return Enumerable.Empty<MatchDto>();
            }
            var result = _mapper.Map<IEnumerable<MatchDto>>(data);
            return result;
        }

        public async Task<MatchDto> MatchResultAsync(MatchDto matchDto)
        {
            var matchEntity = _mapper.Map<Match>(matchDto);

            //var existingMatch = await _context.Matches
            //    .Include(x => x.AwayTeam)
            //    .Include(x => x.HomeTeam)
            //    .FirstOrDefaultAsync(x => x.Id == matchEntity.Id && !x.IsDeleted);.
            var homeTeam = await _context.Teams.FindAsync(matchEntity.HomeTeamId);
            var awayTeam = await _context.Teams.FindAsync(matchEntity.AwayTeamId);

            await _context.Matches.AddAsync(matchEntity);

            if (homeTeam == null || awayTeam == null)
            {
                throw new ArgumentException("Home or Away team not found.");
            }

            if (matchEntity.HomeTeamScore> matchEntity.AwayTeamScore)
            {
                homeTeam.Points += 3; // Home team wins
                awayTeam.Points += 0; // Away team loses
                homeTeam.Wins++;
                awayTeam.Losses++;
          


            }
            else if (matchEntity.HomeTeamScore < matchEntity.AwayTeamScore)
            {
                homeTeam.Points += 0; // Home team loses
                awayTeam.Points += 3; // Away team wins
                awayTeam.Wins++;
                homeTeam.Losses++;
            }
            else
            {
                homeTeam.Points += 1; // Draw
                awayTeam.Points += 1; // Draw
                homeTeam.Draws++;
                awayTeam.Draws++;
            }

            if (matchEntity.HomeTeamScore > 0 || matchEntity.AwayTeamScore > 0)
            {
                foreach (var scorer in matchEntity.MatchScorers)
                {
                    var player = await _context.Players.FindAsync(scorer.PlayerId);
                    if (player != null)
                    {
                        player.GoalsScored++;
                        _context.Players.Update(player);
                    }
                }
            }

            _context.Teams.Update(homeTeam);
            _context.Teams.Update(awayTeam);

           
            await _context.SaveChangesAsync();
            return _mapper.Map<MatchDto>(matchEntity);


        }
    }
}
