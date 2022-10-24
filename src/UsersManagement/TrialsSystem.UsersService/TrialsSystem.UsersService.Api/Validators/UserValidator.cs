using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.BirthDate).LessThan(DateTime.Now.AddYears(-18));
            RuleFor(x => x.Name).Must(value => !string.IsNullOrWhiteSpace(value));
            RuleFor(x => x.Surname).Must(value => !string.IsNullOrWhiteSpace(value));
            RuleFor(x => x).Must(value => !string.Equals(value.Surname, value.Name, StringComparison.InvariantCultureIgnoreCase));
            RuleFor(x => x.Email).EmailAddress();
        }
    }

    public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.BirthDate).LessThan(DateTime.Now.AddYears(-18));
            RuleFor(x => x.Name).Must(value => !string.IsNullOrWhiteSpace(value));
            RuleFor(x => x.Surname).Must(value => !string.IsNullOrWhiteSpace(value));
            RuleFor(x => x).Must(value => !string.Equals(value.Surname, value.Name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
