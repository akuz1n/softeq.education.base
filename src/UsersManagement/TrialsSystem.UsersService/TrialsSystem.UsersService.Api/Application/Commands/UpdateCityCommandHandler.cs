using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, UpdateCityResponse>
    {
        public async Task<UpdateCityResponse> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new UpdateCityResponse());
        }
    }
}
