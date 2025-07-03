using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PFLApp.BLL.Models;

namespace PFLApp.BLL.Validation
{
    public class StadionDtoValidator : AbstractValidator<StadionDto>
    {
        public StadionDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Capacity).GreaterThan(0);
           // RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than 0.");

        }
    }
}
