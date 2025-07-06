using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PFLApp.BLL.Models;
using PFLApp.DAL.DataBase;

namespace PFLApp.BLL.Validation
{
    public class PlayerDtoValidator : AbstractValidator<PlayerDto>
    {
        private readonly PFLDBContext _context;
        public PlayerDtoValidator(PFLDBContext context)
        {
            _context = context;
            RuleFor(x => x.Name)
                .Matches(@"^[a-zA-Z]+$").WithMessage("Name must contain only letters.").MaximumLength(100);
            RuleFor(x => x.Surname)
                .Matches(@"^[a-zA-Z]+$").WithMessage("Surname must contain only letters.").MaximumLength(100);
            RuleFor(x => x.GoalsScored).GreaterThanOrEqualTo(0);
            RuleFor(x => x.TeamId).GreaterThan(0);
            //RuleFor(x => x.ShirtNumber).InclusiveBetween(1, 99).MustAsync(async (playerDto, shirtNumber, cancellation) =>
            //{
            //    // Check if the shirt number already exists in the team
            //    var exists = await _context.Players.AnyAsync(p => p.ShirtNumber == shirtNumber && p.TeamId == playerDto.TeamId);
            //    return !exists;
            //}).WithMessage("Shirt number must be unique within the team.");
            RuleFor(x => x.ShirtNumber).Must((playerDto, shirtNumber) => IsValidShirtNumber(playerDto.TeamId, shirtNumber)).WithMessage("bu nomreli shirt var").InclusiveBetween(1,99);

        }
        public bool IsValidShirtNumber(int teamId, int shirtNumber)
        {
            // Check if the shirt number already exists in the team
            return !_context.Players.Any(p => p.ShirtNumber == shirtNumber && p.TeamId == teamId);

        }

    }
}
