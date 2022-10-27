namespace TrialsSystem.UserTasksService.Domain
{
    public class UserTask : Entity
    {
        public UserTask(string name, string status, Dictionary<string, string> additionalProperties)
        {
            Name = name;
            Status = status;
            AdditionalProperties = additionalProperties;
        }

        public string Name { get; private set; }

        public string Status { get; private set; }

        public Dictionary<string, string> AdditionalProperties { get; private set; }
    }
}