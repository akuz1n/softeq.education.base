using MediatR;

namespace TrialsSystem.UsersService.Api.Application.City.Commands
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand>
    {
        public async Task<Unit> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Unit.Value);
        }
    }
}
