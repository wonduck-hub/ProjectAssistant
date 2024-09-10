using ProjectAssistant1.Models.Models.ChatRoomModel;
using ProjectAssistant1.Models.Models.UserWorkModel;
using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using ProjectAssistant1.Models.Models.WorkspaceWorkModel;
using System;
using System.Text.Json.Serialization;

namespace ProjectAssistant1.Models.WorkspaceModel
{
    public class Workspace
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? CreateUserId { get; set; }
        public string? ModifiedUserId { get; set; }

        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public bool IsDeleted { get; set; } = false;

        // 관계용
        [JsonIgnore]
        public virtual IEnumerable<WorkspaceUser> WorkspaceUsers { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<WorkspaceWork> WorkspaceWorks { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<UserWork> UserWorks { get; set; }
        [JsonIgnore]
        public virtual ICollection<ChatRoom> ChatRooms { get; set; }
    }
}
