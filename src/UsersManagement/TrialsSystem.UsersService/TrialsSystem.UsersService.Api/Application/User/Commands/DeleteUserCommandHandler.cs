using MediatR;

namespace TrialsSystem.UsersService.Api.Application.User.Commands
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
