﻿using FluentValidation;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Validation
{
    public class CreateUserTaskRequestValidator : AbstractValidator<CreateUserTaskRequest>
    {
        public CreateUserTaskRequestValidator()
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
