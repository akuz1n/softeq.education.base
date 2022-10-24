using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class DeleteCityCommand : IRequest
    {
        public string Name { get; set; }

        public DeleteCityCommand(string name)
        {
            Name = name;
        }
    }
}
