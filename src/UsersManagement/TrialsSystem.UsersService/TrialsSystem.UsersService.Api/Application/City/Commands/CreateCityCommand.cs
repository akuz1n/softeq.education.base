using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.City.Commands
{
    public class CreateCityCommand : IRequest<CreateCityResponse>
    {
        public string Name { get; }

        public CreateCityCommand(string name)
        {
            Name = name;
        }
    }
}
