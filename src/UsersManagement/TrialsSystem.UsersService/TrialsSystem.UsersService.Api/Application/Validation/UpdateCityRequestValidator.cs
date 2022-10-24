using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    public class UpdateCityRequestValidator : AbstractValidator<UpdateCityRequest>
    {
        public UpdateCityRequestValidator()
        {
            RuleFor(x => x.Name)
                .Must(value => !string.IsNullOrWhiteSpace(value))
                .WithMessage("Name should not be empty or whitespace");
        }
    }
}
