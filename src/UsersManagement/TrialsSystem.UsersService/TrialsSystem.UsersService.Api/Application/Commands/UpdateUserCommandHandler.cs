using MediatR;
using TrialsSystem.UsersService.Api.Exceptions;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
