using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
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
