using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;

namespace TrialsSystem.UsersService.Api.Application.Device.Queries
{
    public class DeviceQuery : IRequest<GetDeviceResponse>
    {
        public DeviceQuery(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
