using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFLApp.BLL.Models;
using FluentValidation;

namespace PFLApp.BLL.Validation
{
    public class TeamDtoValidator : AbstractValidator<TeamDto>
    {
        public TeamDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.TeamNumber).InclusiveBetween(1, 99);
            RuleFor(x => x.StadionId).GreaterThan(0).WithMessage("StadionId must be greater than 0.");
           // RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than 0.");
            //RuleFor(x => x.Players)
            //    .Must(players => players != null && players.Count > 0)
            //    .WithMessage("Team must have at least 1 player.");

        }
    }

}
