using MediatR;
using System.Collections.Generic;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.City.Queries
{
    public class CitiesQueryHandler : IRequestHandler<CitiesQuery, IEnumerable<GetCityResponse>>
    {
        public CitiesQueryHandler()
        {

        }

        public async Task<IEnumerable<GetCityResponse>> Handle(CitiesQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<GetCityResponse>());
        }
    }
}
