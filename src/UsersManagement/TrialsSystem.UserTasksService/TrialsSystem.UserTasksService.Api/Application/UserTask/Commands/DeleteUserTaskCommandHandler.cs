using MediatR;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Commands
{
    public class DeleteUserTaskCommandHandler : IRequestHandler<DeleteUserTaskCommand>
    {
        public async Task<Unit> Handle(DeleteUserTaskCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
