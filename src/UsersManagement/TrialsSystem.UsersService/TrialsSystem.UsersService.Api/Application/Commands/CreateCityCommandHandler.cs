using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CreateCityResponse>
    {
        public async Task<CreateCityResponse> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new CreateCityResponse());
        }
    }
}
