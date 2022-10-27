using MediatR;

namespace TrialsSystem.UsersService.Api.Application.User.Commands
{
    public class DeleteUserCommand : IRequest
    {
        public DeleteUserCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }

    }
}
