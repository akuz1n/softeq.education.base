using TrialsSystem.UsersService.Domain.AggregatesModel;

namespace TrialsSystem.UsersService.Api.Application.Services
{
    public class UserTaskService
    {
        public async Task<IEnumerable<UserTask>> GetAll()
        {
            return await Task.FromResult(new List<UserTask>());
        }
    }
}
