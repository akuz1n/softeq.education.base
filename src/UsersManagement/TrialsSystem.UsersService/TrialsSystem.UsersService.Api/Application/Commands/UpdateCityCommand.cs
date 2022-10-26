using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateCityCommand : IRequest<UpdateCityResponse>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public UpdateCityCommand(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
