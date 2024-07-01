using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectAssistant1.Models.WorkspaceModel;
using ProjectAssistant1.Models.Models.ChatModel;

namespace ProjectAssistant1.Models.Models.ChatRoomModel
{
    public class ChatRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNotification { get; set; }

        // Foreign key for Workspace
        public int WorkspaceId { get; set; }

        // Navigation property for the Workspace foreign key
        public virtual Workspace Workspace { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
    }
}
