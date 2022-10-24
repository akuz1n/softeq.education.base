using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand>
    {
        public async Task<Unit> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
