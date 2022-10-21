using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UserQueryHandler : IRequestHandler<UserQuery, GetUsersResponse>
    {
        public UserQueryHandler()
        {
        }

        public Task<GetUsersResponse> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetUsersResponse());
        }
    }
}
