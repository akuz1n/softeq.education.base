using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class DevicesQueryHandler : IRequestHandler<DevicesQuery, IEnumerable<GetDeviceResponse>>
    {
        public DevicesQueryHandler()
        {

        }

        public async Task<IEnumerable<GetDeviceResponse>> Handle(DevicesQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<GetDeviceResponse>());
        }
    }
}
