using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class CityQueryHandler : IRequestHandler<CityQuery, GetCityResponse>
    {
        public async Task<GetCityResponse> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetCityResponse());
        }
    }
}
