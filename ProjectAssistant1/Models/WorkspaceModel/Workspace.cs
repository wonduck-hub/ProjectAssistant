using System;

namespace ProjectAssistant1.Models.WorkspaceModel
{
    public class Workspace
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CreateUserId { get; set; }
        public string ModifiedUserId { get; set; }

        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}
