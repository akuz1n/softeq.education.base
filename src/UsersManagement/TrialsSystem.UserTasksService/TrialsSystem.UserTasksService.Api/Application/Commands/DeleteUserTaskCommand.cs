using MediatR;

namespace TrialsSystem.UserTasksService.Api.Application.Commands
{
    public class DeleteUserTaskCommand : IRequest
    {
        public string Id { get; set; }

        public DeleteUserTaskCommand(string id)
        {
            Id = id;
        }
    }
}
