using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class CitiesQuery : IRequest<IEnumerable<GetCityResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public CitiesQuery(int? skip, int? take)
        {
            Skip = skip;
            Take = take;
        }
    }
}
