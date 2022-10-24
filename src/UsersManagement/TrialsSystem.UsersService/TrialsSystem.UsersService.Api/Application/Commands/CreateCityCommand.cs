using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateCityCommand : IRequest
    {
        public string Name { get; set; }

        public CreateCityCommand(string name)
        {
            Name = name;
        }
    }
}
