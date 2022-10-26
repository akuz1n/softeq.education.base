using MediatR;
using TrialsSystem.UsersService.Api.Exceptions;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.User.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserResponse>
    {
        public async Task<UpdateUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == "42")
            {
                throw new TrialUserNotFondException(request.Id);
            }

            return await Task.FromResult(new UpdateUserResponse());
        }
    }
}
