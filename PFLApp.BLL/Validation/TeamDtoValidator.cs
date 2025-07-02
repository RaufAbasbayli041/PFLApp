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
            RuleFor(x => x.Code).InclusiveBetween(1, 99);
        }
    }

}
