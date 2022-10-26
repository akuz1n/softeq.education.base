using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.User.Queries
{
    public class UserQueryHandler : IRequestHandler<UserQuery, GetUserResponse>
    {
        public UserQueryHandler()
        {
        }

        public Task<GetUserResponse> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetUserResponse());
        }
    }
}
