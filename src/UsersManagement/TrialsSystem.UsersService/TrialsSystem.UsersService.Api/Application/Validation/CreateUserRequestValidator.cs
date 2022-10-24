using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(u => u.BirthDate)
                .Must(u => u < DateTime.Now.AddYears(-18)).WithMessage("The participant should be older than 18 years.");
            RuleFor(x => x.Name)
                .Must(value => !string.IsNullOrWhiteSpace(value)).WithMessage("Name shouldn't be empty or whitespace");
            RuleFor(x => x.Surname)
                .Must(value => !string.IsNullOrWhiteSpace(value)).WithMessage("Surname shouldn't be empty or whitespace");
            RuleFor(x => x)
                .Must(value => !string.Equals(value.Surname, value.Name, StringComparison.InvariantCultureIgnoreCase)).WithMessage("Name and surname should be different");
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Email should be a valid email address");
        }
    }
}
