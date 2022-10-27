using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.City.Commands
{
    public class UpdateCityCommand : IRequest<UpdateCityResponse>
    {
        public string Id { get; }

        public string Name { get; }

        public UpdateCityCommand(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
