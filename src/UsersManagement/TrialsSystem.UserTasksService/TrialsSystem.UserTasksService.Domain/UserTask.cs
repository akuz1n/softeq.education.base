namespace TrialsSystem.UserTasksService.Domain
{
    public class UserTask : Entity
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }
    }
}