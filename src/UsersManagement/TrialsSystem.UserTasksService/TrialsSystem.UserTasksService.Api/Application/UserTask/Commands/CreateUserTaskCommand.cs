using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Commands
{
    public class CreateUserTaskCommand : IRequest<CreateUserTaskResponse>
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }

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
