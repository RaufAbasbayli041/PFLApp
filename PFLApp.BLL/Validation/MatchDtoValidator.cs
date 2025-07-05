using FluentValidation;
using PFLApp.BLL.Models;

namespace PFLApp.BLL.Validation
{
    public class MatchDtoValidator : AbstractValidator<MatchDto>
    {
        public MatchDtoValidator()
        {
            RuleFor(x => x.Week).InclusiveBetween(1, 7);
            RuleFor(x => x.HomeTeamId).NotEqual(x => x.AwayTeamId)
                .WithMessage("Ev və qonaq komanda eyni ola bilməz.");
            RuleFor(x => x.HomeTeamScore).GreaterThanOrEqualTo(0);
            RuleFor(x => x.AwayTeamScore).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Goals).NotNull();
        }
    }
}
