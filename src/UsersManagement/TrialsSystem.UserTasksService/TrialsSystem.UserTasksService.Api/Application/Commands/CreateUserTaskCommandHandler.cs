using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.Commands
{
    public class CreateUserTaskCommandHandler : IRequestHandler<CreateUserTaskCommand, CreateUserTaskResponse>
    {
        public async Task<CreateUserTaskResponse> Handle(CreateUserTaskCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new CreateUserTaskResponse());
        }
    }
}
