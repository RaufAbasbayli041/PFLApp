using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PFLApp.BLL.Models;

namespace PFLApp.BLL.Validation
{
    public class StadiumDtoValidator : AbstractValidator<StadionDto>
    {
        public StadiumDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Capacity).GreaterThan(0);
        }
    }
}
