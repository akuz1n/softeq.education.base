using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.Queries
{
    public class UserTaskQueryHandler : IRequestHandler<UserTaskQuery, GetUserTaskResponse>
    {
        public async Task<GetUserTaskResponse> Handle(UserTaskQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetUserTaskResponse());
        }
    }
}
