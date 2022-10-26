using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Device.Commands
{
    public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand>
    {
        public async Task<Unit> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
