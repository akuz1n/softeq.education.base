using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateCityCommand : IRequest<CreateCityResponse>
    {
        public string Name { get; set; }

        public CreateCityCommand(string name)
        {
            Name = name;
        }
    }
}
