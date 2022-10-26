namespace TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto
{
    public class UpdateUserTaskResponse : IdNameDto
    {
        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }
    }
}
