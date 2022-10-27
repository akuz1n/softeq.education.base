using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Commands
{
    public class CreateUserTaskCommand : IRequest<CreateUserTaskResponse>
    {
        public string Name { get; }

        public string Status { get; }

        public Dictionary<string, string> AdditionalProperties { get; }

        public CreateUserTaskCommand(string name,
            string status,
            Dictionary<string, string> additionalProperties)
        {
            Name = name;
            Status = status;
            AdditionalProperties = additionalProperties;
        }
    }
}
