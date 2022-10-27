﻿namespace TrialsSystem.UserTasksService.Domain
{
    public class Entity
    {
        public string Id { get; protected set; }
        public bool IsDeleted { get; protected set; }

        public DateTime CreatedDate { get; protected set; }
        public DateTime LastModifiedDate { get; protected set; }

    }
}