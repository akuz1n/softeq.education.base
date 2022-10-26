using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class DevicesQuery : IRequest<IEnumerable<GetDeviceResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public DevicesQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}
