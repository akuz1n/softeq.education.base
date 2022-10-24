using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class DeleteDeviceCommand : IRequest
    {
        public DeleteDeviceCommand(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

    }
}
