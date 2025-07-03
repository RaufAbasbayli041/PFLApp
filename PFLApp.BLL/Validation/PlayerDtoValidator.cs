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
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than 0.");
            RuleFor(x => x.Name)
                .Matches(@"^[a-zA-Z]+$").WithMessage("Name must contain only letters.").MaximumLength(100);
            RuleFor(x => x.Surname)
                .Matches(@"^[a-zA-Z]+$").WithMessage("Surname must contain only letters.").MaximumLength(100);


            RuleFor(x => x.ShirtNumber).InclusiveBetween(1, 99);            
            RuleFor(x => x.GoalsScored).GreaterThanOrEqualTo(0);
            RuleFor(x => x.TeamId).GreaterThan(0);
        }
    }
}
