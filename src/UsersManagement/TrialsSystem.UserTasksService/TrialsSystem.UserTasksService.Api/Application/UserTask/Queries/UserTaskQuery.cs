using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Application.UserTask.Queries
{
    public class UserTaskQuery : IRequest<GetUserTaskResponse>
    {
        public string Id { get; set; }

        public UserTaskQuery(string id)
        {
            Id = id;
        }
    }
}
