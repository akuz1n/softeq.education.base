using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Commands
{
    public class UpdateUserTaskCommand : IRequest<UpdateUserTaskResponse>
    {
        public string Id { get; }

        public string Name { get; }

        public string Status { get; }

        public Dictionary<string, string> AdditionalProperties { get; }

        public UpdateUserTaskCommand(string id,
            string name,
            string status,
            Dictionary<string, string> additionalProperties)
        {
            Id = id;
            Name = name;
            Status = status;
            AdditionalProperties = additionalProperties;
        }
    }
}
