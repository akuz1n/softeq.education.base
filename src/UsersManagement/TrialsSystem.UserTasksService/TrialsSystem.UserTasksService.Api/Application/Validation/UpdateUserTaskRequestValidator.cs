using FluentValidation;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.Validation
{
    public class UpdateUserTaskRequestValidator : AbstractValidator<UpdateUserTaskRequest>
    {
        public UpdateUserTaskRequestValidator()
        {
            RuleFor(x => x.Name)
                .Must(value => !string.IsNullOrWhiteSpace(value))
                .WithMessage("Name shouldn't be empty or whitespace");
            RuleFor(x => x.Status)
                .Must(value => !string.IsNullOrWhiteSpace(value))
                .WithMessage("Status shouldn't be empty or whitespace");
        }
    }
}
