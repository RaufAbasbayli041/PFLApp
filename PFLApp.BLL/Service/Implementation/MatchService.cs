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
    public class MatchService : GenericService<Match, MatchDto>, IMatchService
    {
        private readonly IMatchRepository _repository;
        public MatchService(IMatchRepository repository,IMapper mapper,IValidator<MatchDto> validator ) : base(repository, mapper,validator)
        {
            _repository = repository;

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
    }
}
