using System.Reflection.Metadata.Ecma335;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateDeviceCommandHandler : IRequestHandler<CreateDeviceCommand, CreateDeviceResponse>
    {
        public async Task<CreateDeviceResponse> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new CreateDeviceResponse());
        }
    }
}
