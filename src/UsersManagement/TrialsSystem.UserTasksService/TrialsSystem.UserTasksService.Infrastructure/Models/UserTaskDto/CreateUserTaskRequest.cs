namespace TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto
{
    public class CreateUserTaskRequest
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }
    }
}
