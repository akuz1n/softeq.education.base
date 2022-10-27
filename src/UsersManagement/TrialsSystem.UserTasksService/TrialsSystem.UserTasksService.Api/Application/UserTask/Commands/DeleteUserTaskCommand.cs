using MediatR;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Commands
{
    public class DeleteUserTaskCommand : IRequest
    {
        public string Id { get; }

        public DeleteUserTaskCommand(string id)
        {
            Id = id;
        }
    }
}
