using ProjectAssistant1.Models.Models.ChatRoomModel;
using ProjectAssistant1.Models.Models.UserWorkModel;
using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using ProjectAssistant1.Models.Models.WorkspaceWorkModel;
using System;

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
        public IEnumerable<WorkspaceUser> WorkspaceUsers { get; set; }
        public IEnumerable<WorkspaceWork> WorkspaceWorks { get; set; }
        public IEnumerable<UserWork> UserWorks { get; set; }
        public virtual ICollection<ChatRoom> ChatRooms { get; set; }
    }
}
