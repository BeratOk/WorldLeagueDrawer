using FluentValidation;

namespace WorldLeague.Application.Draw.CreateDraw;

public class CreateDrawValidator : AbstractValidator<CreateDrawRequest>
{
    public CreateDrawValidator()
    {
        RuleFor(x => x.DrawerName).NotEmpty();
        RuleFor(x => x.DrawerSurname).NotEmpty();
        var groupCapacityConditions = new List<int>() { 4, 8 };
        RuleFor(x => x.GroupCount)
          .Must(x => groupCapacityConditions.Contains(x))
          .WithMessage("Please only choose: " + String.Join(" or ", groupCapacityConditions));
    }
}