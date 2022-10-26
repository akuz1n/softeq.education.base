using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.City.Queries
{
    public class CityQuery : IRequest<GetCityResponse>
    {
        public string Id { get; set; }

        public CityQuery(string id)
        {
            Id = id;
        }
    }
}
