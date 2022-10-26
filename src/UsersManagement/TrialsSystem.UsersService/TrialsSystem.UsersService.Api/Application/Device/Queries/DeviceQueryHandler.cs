using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;

namespace TrialsSystem.UsersService.Api.Application.Device.Queries
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
