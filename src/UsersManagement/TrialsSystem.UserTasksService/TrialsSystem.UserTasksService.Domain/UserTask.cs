namespace TrialsSystem.UserTasksService.Domain
{
    public class UserTask : Entity
    {
        public string Name { get; private set; }

        public string Status { get; private set; }

        public Dictionary<string, string> AdditionalProperties { get; private set; }
    }
}