using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.Queries
{
    public class UserTasksQuery : IRequest<IEnumerable<GetUserTaskResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public UserTasksQuery(int? skip, int? take)
        {
            Skip = skip;
            Take = take;
        }
    }
}
