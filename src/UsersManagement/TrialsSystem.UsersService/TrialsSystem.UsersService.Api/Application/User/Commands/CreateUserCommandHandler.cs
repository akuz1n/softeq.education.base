using MediatR;
using TrialsSystem.UsersService.Api.Exceptions;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.User.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
    {
        public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (1 == 2)
            {
                throw new EmailIsTakenException(request.Email);
            }

            return new CreateUserResponse();
        }
    }
}
