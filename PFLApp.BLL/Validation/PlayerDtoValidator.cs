using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PFLApp.BLL.Models;

namespace PFLApp.BLL.Validation
{
    public class PlayerDtoValidator : AbstractValidator<PlayerDto>
    {
        public PlayerDtoValidator()
        {
            RuleFor(x => x.ShirtNumber).InclusiveBetween(1, 99);
            RuleFor(x => x.Surname).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.GoalsScored).GreaterThanOrEqualTo(0);
            RuleFor(x => x.TeamId).GreaterThan(0);
        }
    }
}
