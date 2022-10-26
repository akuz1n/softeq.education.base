using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.City.Validation
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
