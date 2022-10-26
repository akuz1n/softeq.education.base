using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Commands
{
    public class UpdateUserTaskCommand : IRequest<UpdateUserTaskResponse>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }

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
