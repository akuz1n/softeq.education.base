using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateCityCommand : IRequest
    {
        public string Name { get; set; }

        public string NewName { get; set; }

        public UpdateCityCommand(string name, string newName)
        {
            Name = name;
            NewName = newName;
        }
    }
}
