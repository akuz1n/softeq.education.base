using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class DeviceQueryHandler : IRequestHandler<DeviceQuery, GetDeviceResponse>
    {
        public DeviceQueryHandler()
        {
        }

        public async Task<GetDeviceResponse> Handle(DeviceQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetDeviceResponse());
        }
    }
}
