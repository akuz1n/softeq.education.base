namespace TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto
{
    public class GetUserTaskResponse : IdNameDto
    {
        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }
    }
}
