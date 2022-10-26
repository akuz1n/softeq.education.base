using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UsersQueryHandler : IRequestHandler<UsersQuery, IEnumerable<GetUserResponse>>
    {
        public UsersQueryHandler()
        {

        }

        public async Task<IEnumerable<GetUserResponse>> Handle(UsersQuery request, CancellationToken cancellationToken)
        {
            return new List<GetUserResponse>();
        }
    }
}
