using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Validation
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.BirthDate).LessThan(DateTime.Now.AddYears(-18));
            RuleFor(x => x.Name).Must(value => !string.IsNullOrWhiteSpace(value));
            RuleFor(x => x.Surname).Must(value => !string.IsNullOrWhiteSpace(value));
            RuleFor(x => x).Must(value => !string.Equals(value.Surname, value.Name, StringComparison.InvariantCultureIgnoreCase));
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
