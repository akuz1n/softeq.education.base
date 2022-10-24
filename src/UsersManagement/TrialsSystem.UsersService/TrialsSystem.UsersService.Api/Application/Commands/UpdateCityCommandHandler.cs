using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand>
    {
        public async Task<Unit> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
