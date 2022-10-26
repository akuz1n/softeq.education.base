using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.User.Queries
{
    public class UserQuery : IRequest<GetUserResponse>
    {
        public UserQuery(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}
