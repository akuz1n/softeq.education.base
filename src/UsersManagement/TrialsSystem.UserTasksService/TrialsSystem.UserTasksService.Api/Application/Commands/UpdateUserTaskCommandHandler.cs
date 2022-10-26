using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.Commands
{
    public class UpdateUserTaskCommandHandler : IRequestHandler<UpdateUserTaskCommand, UpdateUserTaskResponse>
    {
        public async Task<UpdateUserTaskResponse> Handle(UpdateUserTaskCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new UpdateUserTaskResponse());
        }
    }
}
