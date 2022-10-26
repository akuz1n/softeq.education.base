using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.Queries
{
    public class UserTasksQueryHandler : IRequestHandler<UserTasksQuery, IEnumerable<GetUserTaskResponse>>
    {
        public async Task<IEnumerable<GetUserTaskResponse>> Handle(UserTasksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<GetUserTaskResponse>());
        }
    }
}
